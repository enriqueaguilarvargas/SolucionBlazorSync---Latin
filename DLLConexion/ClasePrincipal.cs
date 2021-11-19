using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DLLConexion
{
    public class ClasePrincipal
    {
        public List<Datos> Lista;
        public bool Guardar(string Fecha, double Contagios, double Decesos)
        {
            var Conexion = new SqlConnection
                ("Server=tcp:{TuServidordebaseDeDatosenAzure},1433;Initial Catalog={TuBasedeDatos};Persist Security Info=False;User ID={TuUsuario};Password={TuPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            try
            {
                var Insertar = new SqlCommand("EXEC Insertar '" + Fecha + "','" +
                    Contagios + "','" + Decesos + "'", Conexion);
                Conexion.Open();
                Insertar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception)
            {
                Conexion.Close();
                return false;
            }
        }
        public List<Datos> Consulta()
        {
            var dt = new DataTable();
            var Conexion = new SqlConnection
                ("Server=tcp:{TuServidordebaseDeDatosenAzure},1433;Initial Catalog={TuBasedeDatos};Persist Security Info=False;User ID={TuUsuario};Password={TuPassword};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            var cmd = new SqlCommand("EXEC Consultar", Conexion);
            try
            {
                Conexion.Open();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Conexion.Close();
                Lista = new List<Datos>();
                for (int i=0; i<dt.Rows.Count; i++)
                {
                    Datos datos = new Datos();
                    datos.Fecha = dt.Rows[i]["fecha"].ToString();
                    datos.Contagios = double.Parse(dt.Rows[i]["Contagios"].ToString());
                    datos.Decesos = double.Parse(dt.Rows[i]["Decesos"].ToString());
                    Lista.Add(datos);
                }
                return Lista;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }
        }
    }
    public class Datos
    {
        public string Fecha { get; set; }
        public double Contagios { get; set; }
        public double Decesos { get; set; }
    }
}

using DLLConexion;
using System.Collections.Generic;
namespace WebBlazor.Data
{
    public class EnlacedeDatos
    {
        public List<Datos> datos;
        public List<DLLConexion.Datos> Consultar()
        {
            var Consulta = new ClasePrincipal();
            var Lista = Consulta.Consulta();
            return Lista;
        }
        public bool Inserta(string Fecha, double Contagios, double Decesos)
        {
            var Guardar = new ClasePrincipal();
            if (Guardar.Guardar(Fecha, Contagios, Decesos))
                return true;
            else
                return false;
        }

    }
    public class Datos
    {
        public string Fecha { get; set; }
        public double Contagios { get; set; }
        public double Decesos { get; set; }
    }
}

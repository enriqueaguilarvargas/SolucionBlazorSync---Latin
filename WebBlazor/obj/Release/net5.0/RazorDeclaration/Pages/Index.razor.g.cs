// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using WebBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\_Imports.razor"
using WebBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Index.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Index.razor"
          
        public List<Paises> DetallePaises = new List<Paises>
    {
        new Paises {Nombre="China", Covid="Mayores Casos", Cantidad="1150000"},
        new Paises { Nombre= "United States", Covid= "Mayores Casos", Cantidad="1750000" },
        new Paises { Nombre= "Russia", Covid= "Mayores Casos", Cantidad="755000"},
        new Paises { Nombre= "Germany", Covid= "Mayores Casos", Cantidad="475000"},
        new Paises { Nombre= "India", Covid= "Mayores Decesos", Cantidad="15550500"},
        new Paises { Nombre= "Mexico", Covid= "Mayores Decesos", Cantidad="1250425"},
        new Paises { Nombre= "Brazil", Covid= "Mayores Decesos", Cantidad="3575052"},
        new Paises { Nombre= "Argentina", Covid= "Mayores Decesos", Cantidad="789525"},
        new Paises { Nombre= "Canada", Covid= "Menor Mortandad", Cantidad="662000"},
        new Paises { Nombre= "Israel", Covid= "Menor Mortandad", Cantidad="75025"},
        new Paises { Nombre= "Sweden", Covid= "Menor Mortandad", Cantidad="57850"},
        new Paises { Nombre= "Australia", Covid= "Menor Mortandad", Cantidad="22520"},
    };
        public class Paises
        {
            public string Nombre { get; set; }
            public string Covid { get; set; }
            public string Cantidad { get; set; }
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

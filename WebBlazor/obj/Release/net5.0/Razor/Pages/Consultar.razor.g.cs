#pragma checksum "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8752a868ec45d656f56c98e95d29acac2031f366"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
using WebBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consultar")]
    public partial class Consultar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\">\r\n    body {\r\n        background: linear-gradient(to right, #005AA7, #FFFDE4);\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:800px; height:500px;");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(3);
            __builder.AddAttribute(4, "Title", "Contagios y Decesos COVID19");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(6);
                __builder2.AddAttribute(7, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 12 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                      Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Title", "Contagios por Fecha");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryYAxis>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartLegendSettings>(12);
                __builder2.AddAttribute(13, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartTooltipSettings>(15);
                __builder2.AddAttribute(16, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(20);
                    __builder3.AddAttribute(21, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 20 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                               ChartSeriesType.Pareto

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 21 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                      listado

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "XName", "Fecha");
                    __builder3.AddAttribute(24, "YName", "Contagios");
                    __builder3.AddAttribute(25, "Name", "Casos");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.ChartMarker>(27);
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartDataLabel>(29);
                            __builder5.AddAttribute(30, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(32);
                    __builder3.AddAttribute(33, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 29 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                               ChartSeriesType.Column

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 30 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                      listado

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "XName", "Fecha");
                    __builder3.AddAttribute(36, "YName", "Decesos");
                    __builder3.AddAttribute(37, "Name", "Casos");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.ChartMarker>(39);
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.ChartDataLabel>(41);
                            __builder5.AddAttribute(42, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "width:800px ; height:500px;");
            __Blazor.WebBlazor.Pages.Consultar.TypeInference.CreateSfGrid_0(__builder, 46, 47, 
#nullable restore
#line 42 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                         listado

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 43 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                         true

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 44 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                          true

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 45 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                            true

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 46 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                           true

#line default
#line hidden
#nullable disable
            , 52, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(53);
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(55);
                    __builder3.AddAttribute(56, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                        10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(58);
                    __builder3.AddAttribute(59, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                               nameof(Datos.Fecha)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "HeaderText", "Fecha");
                    __builder3.AddAttribute(61, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 51 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                   TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(64);
                    __builder3.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                               nameof(Datos.Contagios)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "HeaderText", "Confirmados");
                    __builder3.AddAttribute(67, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 55 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                   TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(70);
                    __builder3.AddAttribute(71, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                               nameof(Datos.Decesos)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "HeaderText", "Decesos");
                    __builder3.AddAttribute(73, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 59 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
                                   TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Width", "120");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Consultar.razor"
       
    List<DLLConexion.Datos> listado;
    protected override void OnInitialized()
    {
        listado = new EnlacedeDatos().Consultar();
        base.OnInitialized();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WebBlazor.Pages.Consultar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "AllowGrouping", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

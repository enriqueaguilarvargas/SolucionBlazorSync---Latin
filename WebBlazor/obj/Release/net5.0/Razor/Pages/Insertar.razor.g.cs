#pragma checksum "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f73b6e831429c2bcf56f95219e43a14b48bdfaf5"
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
#line 2 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
using WebBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Insertar")]
    public partial class Insertar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><p style=\"color:white\">Insertar Información</p></h3>\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    #toast_default .e-meeting::before{\r\n        content: \"\\e705\";\r\n        font-size: 17px;\r\n    }\r\n    .bootstrap4 #toast_default .bootstrap4::before {\r\n        content: \"\\e763\";\r\n        font-size: 20px;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(2, "<style type=\"text/css\">\r\n    body {\r\n        background: linear-gradient(to right, #005AA7, #FFFDE4);\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<td><p style=\"color:white\"> Fecha </p></td>\r\n        ");
            __builder.OpenElement(7, "td");
            __builder.OpenComponent<Syncfusion.Blazor.Calendars.SfDatePicker<DateTime?>>(8);
            __builder.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime?>(
#nullable restore
#line 28 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                        ValorFecha

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ValorFecha = __value, ValorFecha))));
            __builder.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<DateTime?>>>(() => ValorFecha));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "<td><p style=\"color:white\"> Casos Confirmados </p></td>\r\n        ");
            __builder.OpenElement(15, "td");
            __Blazor.WebBlazor.Pages.Insertar.TypeInference.CreateSfNumericTextBox_0(__builder, 16, 17, "Confirmados", 18, "###", 19, 
#nullable restore
#line 37 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                            datos.Contagios

#line default
#line hidden
#nullable disable
            , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => datos.Contagios = __value, datos.Contagios)), 21, () => datos.Contagios);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "<td><p style=\"color:white\"> Decesos </p></td>\r\n        ");
            __builder.OpenElement(25, "td");
            __Blazor.WebBlazor.Pages.Insertar.TypeInference.CreateSfNumericTextBox_1(__builder, 26, 27, "Decesos", 28, "###", 29, 
#nullable restore
#line 46 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                            datos.Decesos

#line default
#line hidden
#nullable disable
            , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => datos.Decesos = __value, datos.Decesos)), 31, () => datos.Decesos);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td><p style=\"color:white\"> Casos Confirmados </p></td>\r\n        ");
            __builder.OpenElement(35, "td");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(36);
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                BtInsertarClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "CssClass", "e-flat");
            __builder.AddAttribute(39, "IsToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                                Content

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(43);
            __builder.AddAttribute(44, "ID", "toast_default");
            __builder.AddAttribute(45, "Title", "Mensaje del Servidor");
            __builder.AddAttribute(46, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                   ToastContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                  4000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Icon", "e-bootstap4");
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(50);
                __builder2.AddAttribute(51, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                           ToastPosition

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(52, (__value) => {
#nullable restore
#line 63 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
               Notificacion1 = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Notifications.SfToast>(54);
            __builder.AddAttribute(55, "ID", "toast_error");
            __builder.AddAttribute(56, "Title", "Error del Servidor");
            __builder.AddAttribute(57, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                   ToastContent2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 74 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                  4000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "Icon", "e-bootstap4");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Notifications.ToastPosition>(61);
                __builder2.AddAttribute(62, "X", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
                       ToastPosition

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 71 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
               Notificacion2 = (Syncfusion.Blazor.Notifications.SfToast)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Enrique\source\repos\SolucionBlazorSync\WebBlazor\Pages\Insertar.razor"
       
    public DateTime? ValorFecha { get; set; } = DateTime.Now;
    SfToast Notificacion1, Notificacion2;
    private string ToastPosition = "Center";
    private string ToastContent = "Guardado Correctamente";
    public string ToastContent2 = "Favor de Consultar a T.I.";
    string Mensaje;
    Datos datos = new Datos();
    SfButton BtnInsertar;
    public string Content = "Insertar";
    protected override void OnInitialized()
    {
        base.OnInitialized();
        datos = new Datos();
    }
    private async Task BtInsertarClick(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        string fechaparse;
        fechaparse = ValorFecha.Value.Date.Year.ToString() + "-" +
                     ValorFecha.Value.Date.Month.ToString() + "-" +
                     ValorFecha.Value.Date.Day.ToString();
        EnlacedeDatos Enlace = new EnlacedeDatos();
        if (Enlace.Inserta(fechaparse, datos.Contagios, datos.Decesos))
        {
            await this.Notificacion1.ShowAsync();
        }else
        {
            await this.Notificacion2.ShowAsync();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WebBlazor.Pages.Insertar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfNumericTextBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Format", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Format", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Estadios\ListEstadios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb3dd73abc3adfaef5b72015d405cbbf9695185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbol.App.Frontend.Pages.Estadios.Pages_Estadios_ListEstadios), @"mvc.1.0.razor-page", @"/Pages/Estadios/ListEstadios.cshtml")]
namespace TorneoFutbol.App.Frontend.Pages.Estadios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbol.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb3dd73abc3adfaef5b72015d405cbbf9695185", @"/Pages/Estadios/ListEstadios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d179c1a50af22e4f8d73bc42157fd366720dfdc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estadios_ListEstadios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista de Estadios</h1>\r\n<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Direccion</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Estadios\ListEstadios.cshtml"
         foreach (var estadio in Model.estadios)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 17 "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Estadios\ListEstadios.cshtml"
               Write(estadio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Estadios\ListEstadios.cshtml"
               Write(estadio.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Oscar Regino\Desktop\Mision tic\Este si\TorneoDeFutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Estadios\ListEstadios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbol.App.Frontend.Pages.Estadios.ListEstadiosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Estadios.ListEstadiosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Estadios.ListEstadiosModel>)PageContext?.ViewData;
        public TorneoFutbol.App.Frontend.Pages.Estadios.ListEstadiosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
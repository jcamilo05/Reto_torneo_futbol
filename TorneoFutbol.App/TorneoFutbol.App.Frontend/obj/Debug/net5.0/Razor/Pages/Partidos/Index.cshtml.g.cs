#pragma checksum "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874b9621ac6a3de8769929255dc23936ca2ec432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbol.App.Frontend.Pages.Partidos.Pages_Partidos_Index), @"mvc.1.0.razor-page", @"/Pages/Partidos/Index.cshtml")]
namespace TorneoFutbol.App.Frontend.Pages.Partidos
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
#line 1 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbol.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874b9621ac6a3de8769929255dc23936ca2ec432", @"/Pages/Partidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d179c1a50af22e4f8d73bc42157fd366720dfdc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Partidos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <div class=""container p-3 my-3 bg-dark text-white"">
    <div class=""row"">
      <div class=""col"">
        <p style=""text-align:center;""><b>Local</b></p>
      </div>
      <div class=""col mb-2 bg-success text-white"">
        <p style=""text-align:center;""><b>Marcador</b></p>
      </div>
      <div class=""col"">
        <p style=""text-align:center;""><b>Visitante</b></p>
      </div>
    </div>
    <div class=""row"">
      <div class=""col"">
        <div>
          <p style=""text-align:center;"">");
#nullable restore
#line 20 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                   Write(Model.partido.EquipoVisitante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n      </div>\r\n      <div class=\"col\">\r\n        <p style=\"text-align:center;\">");
#nullable restore
#line 24 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                 Write(Model.partido.MarcadorInicialVisitante);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                                                           Write(Model.partido.MarcadorInicialLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      </div>\r\n      <div class=\"col\">\r\n        <div>\r\n          <p style=\"text-align:center;\">");
#nullable restore
#line 28 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                   Write(Model.partido.EquipoLocal.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <p style=\"text-align:center;\">");
#nullable restore
#line 34 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                 Write(Model.partido.Arbitro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
      </div>
      <div class=""col mb-2 bg-success text-white"">
        <p style=""text-align:center;""><b>Arbitro</b></p>
      </div>
      <div class=""col"" style=""text-align:center;"">
        <button type=""submit"" class=""btn btn-primary"">Agregar Novedad</button>
      </div>
      <div class=""col mb-2 bg-success text-white"">
        <p style=""text-align:center;""><b>Estadio</b></p>
      </div>
      <div class=""col"">
        <p style=""text-align:center;"">");
#nullable restore
#line 46 "C:\Users\Dhani\Desktop\Master\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Partidos\Index.cshtml"
                                 Write(Model.partido.Estadio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbol.App.Frontend.Pages.Partidos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Partidos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Partidos.IndexModel>)PageContext?.ViewData;
        public TorneoFutbol.App.Frontend.Pages.Partidos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

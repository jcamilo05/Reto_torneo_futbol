#pragma checksum "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "145acc7c6647a910cba2d7c21cf1a61c0ef28ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbol.App.Frontend.Pages.Municipios.Pages_Municipios_DetailsMunicipios), @"mvc.1.0.razor-page", @"/Pages/Municipios/DetailsMunicipios.cshtml")]
namespace TorneoFutbol.App.Frontend.Pages.Municipios
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
#line 1 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbol.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145acc7c6647a910cba2d7c21cf1a61c0ef28ec9", @"/Pages/Municipios/DetailsMunicipios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0ec3b56afe70df83a1b2d92036caaff1fc94f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Municipios_DetailsMunicipios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AddEstadio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListMunicipios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalles de los Municipios</h1>\n<table class=\"table table-dark\">\n    <tr>\n        <th scope=\"col\">Nombre</th>\n        <td>");
#nullable restore
#line 9 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
       Write(Model.municipio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Departamento</th>\n        <td>");
#nullable restore
#line 13 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
       Write(Model.municipio.Departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <th scope=\"col\">Estadio</th>\n");
#nullable restore
#line 17 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
         if (@Model.municipio.Estadio == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145acc7c6647a910cba2d7c21cf1a61c0ef28ec95128", async() => {
                WriteLiteral("Asignar Estadio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
                                                                     WriteLiteral(Model.municipio.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n");
#nullable restore
#line 20 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 23 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
           Write(Model.municipio.Estadio.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 24 "F:\repos\Torneofutbol\TorneoFutbol.App\TorneoFutbol.App.Frontend\Pages\Municipios\DetailsMunicipios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145acc7c6647a910cba2d7c21cf1a61c0ef28ec98233", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbol.App.Frontend.Pages.Municipios.DetailsMunicipiosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Municipios.DetailsMunicipiosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbol.App.Frontend.Pages.Municipios.DetailsMunicipiosModel>)PageContext?.ViewData;
        public TorneoFutbol.App.Frontend.Pages.Municipios.DetailsMunicipiosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\sistemas\git\zurich\Seguros.Zurich\Seguros.Zurich.Site\Views\Seguro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d619fb7340c20526965bb0747cb31c6087b9aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seguro_Index), @"mvc.1.0.view", @"/Views/Seguro/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\sistemas\git\zurich\Seguros.Zurich\Seguros.Zurich.Site\Views\_ViewImports.cshtml"
using Seguros.Zurich.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\sistemas\git\zurich\Seguros.Zurich\Seguros.Zurich.Site\Views\_ViewImports.cshtml"
using Seguros.Zurich.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d619fb7340c20526965bb0747cb31c6087b9aa", @"/Views/Seguro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93fda45100b1591f2bebc4b20faae6cab4a055c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Seguro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "put", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Atualizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Remover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/View/Seguro/Seguro.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\sistemas\git\zurich\Seguros.Zurich\Seguros.Zurich.Site\Views\Seguro\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Seguro</h1>

<button class=""btn btn-success"" id=""botaoCadastrar"" name=""botaoCadastrar"" data-toggle=""modal"" data-target=""#cadastrar"">Cadastrar</button>

<table class=""tabela"">
    <tr>
        <td></td>
    </tr>
</table>


<div class=""modal fade"" id=""cadastrar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exemploModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exemploModalLabel"">Cadastrar</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d619fb7340c20526965bb0747cb31c6087b9aa6863", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""Id"" value=""0"" />
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorVeiculo</label>
                        <input type=""text"" class=""form-control cadastrarValorVeiculo"" id=""valorVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">taxaRisco</label>
                        <input type=""text"" class=""form-control cadastrarTaxaRisco"" id=""taxaRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioRisco</label>
                        <input type=""text"" class=""form-control cadastrarPremioRisco"" id=""premioRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioPuro</label>
                        <input type=""te");
                WriteLiteral(@"xt"" class=""form-control cadastrarPremioPuro"" id=""premioPuro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioComercial</label>
                        <input type=""text"" class=""form-control cadastrarPremioComercial"" id=""premioComercial"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorSeguro</label>
                        <input type=""text"" class=""form-control cadastrarValorSeguro"" id=""valorSeguro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">marcaVeiculo</label>
                        <input type=""text"" class=""form-control cadastrarMarcaVeiculo"" id=""marcaVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">modeloVeiculo</");
                WriteLiteral(@"label>
                        <input type=""text"" class=""form-control cadastrarModeloVeiculo"" id=""modeloVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">nome</label>
                        <input type=""text"" class=""form-control cadastrarNome"" id=""nome"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">cPF</label>
                        <input type=""text"" class=""form-control cadastrarcpf"" id=""cPF"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">idade</label>
                        <input type=""text"" class=""form-control cadastrarIdade"" id=""idade"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btn-Cadastrar"">Salvar Dados</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""editar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exemploModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exemploModalLabel"">Editar</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d619fb7340c20526965bb0747cb31c6087b9aa12467", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""Id"" />
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorVeiculo</label>
                        <input type=""text"" class=""form-control editarValorVeiculo"" id=""valorVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">taxaRisco</label>
                        <input type=""text"" class=""form-control editarTaxaRisco"" id=""taxaRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioRisco</label>
                        <input type=""text"" class=""form-control editarPremioRisco"" id=""premioRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioPuro</label>
                        <input type=""text"" class=""form-con");
                WriteLiteral(@"trol editarPremioPuro"" id=""premioPuro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioComercial</label>
                        <input type=""text"" class=""form-control editarPremioComercial"" id=""premioComercial"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorSeguro</label>
                        <input type=""text"" class=""form-control editarValorSeguro"" id=""valorSeguro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">marcaVeiculo</label>
                        <input type=""text"" class=""form-control editarMarcaVeiculo"" id=""marcaVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">modeloVeiculo</label>
                       ");
                WriteLiteral(@" <input type=""text"" class=""form-control editarModeloVeiculo"" id=""modeloVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">nome</label>
                        <input type=""text"" class=""form-control editarNome"" id=""nome"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">cPF</label>
                        <input type=""text"" class=""form-control editarCpf"" id=""cPF"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">idade</label>
                        <input type=""text"" class=""form-control editarIdade"" id=""idade"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btn-Editar"">Salvar Dados</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""excluir"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exemploModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exemploModalLabel"">Exclusão</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d619fb7340c20526965bb0747cb31c6087b9aa18027", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""Id"" />
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorVeiculo</label>
                        <input type=""text"" class=""form-control cadastrarValorVeiculo"" id=""valorVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">taxaRisco</label>
                        <input type=""text"" class=""form-control cadastrarTaxaRisco"" id=""taxaRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioRisco</label>
                        <input type=""text"" class=""form-control cadastrarPremioRisco"" id=""premioRisco"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioPuro</label>
                        <input type=""text"" class=");
                WriteLiteral(@"""form-control cadastrarPremioPuro"" id=""premioPuro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">premioComercial</label>
                        <input type=""text"" class=""form-control cadastrarPremioComercial"" id=""premioComercial"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">valorSeguro</label>
                        <input type=""text"" class=""form-control cadastrarValorSeguro"" id=""valorSeguro"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">marcaVeiculo</label>
                        <input type=""text"" class=""form-control cadastrarMarcaVeiculo"" id=""marcaVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">modeloVeiculo</label>
  ");
                WriteLiteral(@"                      <input type=""text"" class=""form-control cadastrarModeloVeiculo"" id=""modeloVeiculo"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">nome</label>
                        <input type=""text"" class=""form-control cadastrarNome"" id=""nome"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">cPF</label>
                        <input type=""text"" class=""form-control cadastrarcpf"" id=""cPF"">
                    </div>
                    <div class=""form-group"">
                        <label for=""nome"" class=""col-form-label"">idade</label>
                        <input type=""text"" class=""form-control cadastrarIdade"" id=""idade"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary btn-Excluir"">Confirma a exclusão?</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d619fb7340c20526965bb0747cb31c6087b9aa23110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(function () {\r\n            seguroScript.init();\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

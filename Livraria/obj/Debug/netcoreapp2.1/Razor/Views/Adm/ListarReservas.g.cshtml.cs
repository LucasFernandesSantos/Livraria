#pragma checksum "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e26ac628f099c987dc4db80fc7f253ab733588a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adm_ListarReservas), @"mvc.1.0.view", @"/Views/Adm/ListarReservas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adm/ListarReservas.cshtml", typeof(AspNetCore.Views_Adm_ListarReservas))]
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
#line 1 "C:\Users\Aluno\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e26ac628f099c987dc4db80fc7f253ab733588a4", @"/Views/Adm/ListarReservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1697a0a9c45e8d661f4a7c08009a3739b766f019", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_ListarReservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReservaLivro>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(29, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01802f1261c48e5adfe0270e697b7c8", async() => {
                BeginContext(35, 135, true);
                WriteLiteral("\r\n    <H2><label style=\"color:darkorange; margin-left:10px\"><b><u>Histórico de Reservas:</u></b></label></H2>\r\n    <br />\r\n    <br />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 326, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped"">
    <thead>
        <tr class=""table-dark"">
            <th>IdCliente</th>
            <th>Cliente</th>
            <th>LivroId</th>
            <th>Livro</th>
            <th>Autor</th>       
            <th>IdReserva</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
         foreach (ReservaLivro item in Model)
        {

#line default
#line hidden
            BeginContext(561, 52, true);
            WriteLiteral("        <tr class=\"table-success\">\r\n            <td>");
            EndContext();
            BeginContext(614, 22, false);
#line 23 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.Cliente.ClienteId);

#line default
#line hidden
            EndContext();
            BeginContext(636, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(661, 17, false);
#line 24 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(678, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(703, 28, false);
#line 25 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.DadosLivro.DadosLivroId);

#line default
#line hidden
            EndContext();
            BeginContext(731, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(756, 21, false);
#line 26 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.DadosLivro.Title);

#line default
#line hidden
            EndContext();
            BeginContext(777, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(802, 21, false);
#line 27 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.DadosLivro.Autor);

#line default
#line hidden
            EndContext();
            BeginContext(823, 24, true);
            WriteLiteral(" </td>\r\n            <td>");
            EndContext();
            BeginContext(848, 19, false);
#line 28 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
           Write(item.IdReservaLivro);

#line default
#line hidden
            EndContext();
            BeginContext(867, 25, true);
            WriteLiteral(" </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Aluno\Livraria\Livraria\Views\Adm\ListarReservas.cshtml"
        }

#line default
#line hidden
            BeginContext(903, 363, true);
            WriteLiteral(@"    </tbody>
</table>
<style>
    body {
        position: fixed;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        background: url(https://i.imgur.com/u9sUbQi.jpg) no-repeat center center fixed;
        background-size: cover;
        background-position: center;
        -webkit-filter: blur(px);
    }
</style>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReservaLivro>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0ca4cb369c3c89123312dbcb729c72db5adc36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adm_ListCliente), @"mvc.1.0.view", @"/Views/Adm/ListCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adm/ListCliente.cshtml", typeof(AspNetCore.Views_Adm_ListCliente))]
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
#line 1 "C:\Users\User\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria;

#line default
#line hidden
#line 2 "C:\Users\User\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0ca4cb369c3c89123312dbcb729c72db5adc36", @"/Views/Adm/ListCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1697a0a9c45e8d661f4a7c08009a3739b766f019", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_ListCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 366, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped"">
    <thead>
        <tr class=""table-dark"">
            <th>Nome</th>
            <th>Cpf</th>
            <th>Senha</th>
            <th>Data de Nascimento</th>
            <th>Email</th>
            <th>Telefone</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
         foreach (Cliente item in Model)
        {

#line default
#line hidden
            BeginContext(441, 50, true);
            WriteLiteral("        <tr class=\"table-light\">\r\n            <td>");
            EndContext();
            BeginContext(492, 9, false);
#line 20 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(501, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(525, 8, false);
#line 21 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(533, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(557, 10, false);
#line 22 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(567, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(591, 19, false);
#line 23 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(610, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(634, 10, false);
#line 24 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(644, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(668, 13, false);
#line 25 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(681, 55, true);
            WriteLiteral("</td>\r\n        \r\n\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(736, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7813b74994645f5b094377b47295f0d", async() => {
                BeginContext(829, 7, true);
                WriteLiteral("Remover");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
                                                                                WriteLiteral(item.ClienteId);

#line default
#line hidden
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
            EndContext();
            BeginContext(840, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(895, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc195ddbc64479b0724f9bbdacda7b", async() => {
                BeginContext(985, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
                                                                             WriteLiteral(item.ClienteId);

#line default
#line hidden
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
            EndContext();
            BeginContext(996, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\User\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
        }

#line default
#line hidden
            BeginContext(1045, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591

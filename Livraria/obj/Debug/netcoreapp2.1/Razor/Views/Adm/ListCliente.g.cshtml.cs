#pragma checksum "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b15613ea89efd1139c437bf432b850d2eed502a"
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
#line 1 "C:\Users\gusta\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria;

#line default
#line hidden
#line 2 "C:\Users\gusta\Livraria\Livraria\Views\_ViewImports.cshtml"
using Livraria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b15613ea89efd1139c437bf432b850d2eed502a", @"/Views/Adm/ListCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1697a0a9c45e8d661f4a7c08009a3739b766f019", @"/Views/_ViewImports.cshtml")]
    public class Views_Adm_ListCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 394, true);
            WriteLiteral(@"
<table class=""table table-hover table-striped"">
    <thead>
        <tr class=""table-dark"">
            <th>Nome</th>
            <th>CPF</th>
            <th>Senha</th>
            <th>Data de Nascimento</th>
            <th>Email</th>
            <th>Telefone</th>
            <th>CEP</th>

            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
         foreach (Cliente item in Model)
        {

#line default
#line hidden
            BeginContext(469, 52, true);
            WriteLiteral("        <tr class=\"table-success\">\r\n            <td>");
            EndContext();
            BeginContext(522, 9, false);
#line 22 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(531, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(555, 8, false);
#line 23 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(563, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(587, 10, false);
#line 24 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(597, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(621, 19, false);
#line 25 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(640, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(664, 10, false);
#line 26 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(674, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(698, 13, false);
#line 27 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(711, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(735, 17, false);
#line 28 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
           Write(item.Endereco.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(752, 47, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(799, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c5df2ab9a504739802829a9d61dd0c4", async() => {
                BeginContext(884, 7, true);
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
#line 33 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
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
            BeginContext(895, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(950, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a41e7ed5af6748abb9ce6392c4622d6c", async() => {
                BeginContext(1035, 7, true);
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
#line 36 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
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
            BeginContext(1046, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\gusta\Livraria\Livraria\Views\Adm\ListCliente.cshtml"
        }

#line default
#line hidden
            BeginContext(1095, 22, true);
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

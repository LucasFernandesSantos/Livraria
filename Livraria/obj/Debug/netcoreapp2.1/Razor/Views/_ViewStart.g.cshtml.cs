#pragma checksum "C:\Users\gusta\Livraria\Livraria\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcd5a20ce34aac1134cbb0ce1a21ffb69d6e1834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_ViewStart.cshtml", typeof(AspNetCore.Views__ViewStart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd5a20ce34aac1134cbb0ce1a21ffb69d6e1834", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1697a0a9c45e8d661f4a7c08009a3739b766f019", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\gusta\Livraria\Livraria\Views\_ViewStart.cshtml"
  
    var controllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    if (controllerName.Equals("Home"))
    {
        Layout = "~/Views/Shared/_LayoutHome.cshtml";
    }
    else if (controllerName.Equals("Adm"))
    {
        Layout = "~/Views/Shared/_LayoutAdm.cshtml";
    }
    else if (controllerName.Equals("Cliente"))
    {
        Layout = "~/Views/Shared/_LayoutCliente.cshtml";
    }
    else if (controllerName.Equals("Livro"))
    {
        Layout = "~/Views/Shared/_LayoutAdm.cshtml";
    }
    else if (controllerName.Equals("GeneroLivro"))
    {
        Layout = "~/Views/Shared/_LayoutAdm.cshtml";
    }
    else if (controllerName.Equals("ReservaLivro"))
    {
        Layout = "~/Views/Shared/_LayoutCliente.cshtml";
    }
    else if (controllerName.Equals("Devolucao"))
    {
        Layout = "~/Views/Shared/_LayoutCliente.cshtml";
    }




#line default
#line hidden
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

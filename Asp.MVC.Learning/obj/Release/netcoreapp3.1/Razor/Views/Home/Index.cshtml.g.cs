#pragma checksum "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a908c23ddac53ab6e53e74e7bb844e581c72f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\_ViewImports.cshtml"
using Asp.MVC.Learning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\_ViewImports.cshtml"
using Asp.MVC.Learning.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\_ViewImports.cshtml"
using NetCoreFastenalLib.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\_ViewImports.cshtml"
using NetCoreFastenalLib;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a908c23ddac53ab6e53e74e7bb844e581c72f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edadd4e1083bff5e0b47dc4d0b5c369ad81b9e4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewData["message"] = "hello world";
    string myString = "this the mestring";

     object clickMe()
    {
        myString = $"click at {DateTime.Now}";
        return myString;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <p>");
#nullable restore
#line 16 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Index.cshtml"
      Write(myString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 364, "\"", 384, 1);
#nullable restore
#line 17 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Index.cshtml"
WriteAttributeValue("", 374, clickMe(), 374, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    </div>\r\n\r\n\r\n");
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

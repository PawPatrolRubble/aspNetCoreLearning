#pragma checksum "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21aa12af72b71f92a2bf19929a0f37a857d02dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21aa12af72b71f92a2bf19929a0f37a857d02dde", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edadd4e1083bff5e0b47dc4d0b5c369ad81b9e4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Test>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <h1>thanks for your submitting</h1>\r\n\r\n    <div class=\"d-sm-flex\">\r\n        <div>\r\n\r\n");
#nullable restore
#line 17 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Thanks.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>the name is : ");
#nullable restore
#line 19 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Thanks.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>the content is: ");
#nullable restore
#line 20 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Thanks.cshtml"
                                Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\Thanks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd3b2ad96009c17628e45d0bada35761f6c7712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewReport), @"mvc.1.0.view", @"/Views/Home/ViewReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd3b2ad96009c17628e45d0bada35761f6c7712", @"/Views/Home/ViewReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edadd4e1083bff5e0b47dc4d0b5c369ad81b9e4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneApproval>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
 if (ViewBag.Approvals!=null && (ViewBag.Approvals as List<OneApproval>).Count > 0)
{
    
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
         foreach (var item in ViewBag.Approvals as List<OneApproval>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">fastenal part number</th>
                        <th scope=""col"">fastenal description</th>
                        <th scope=""col"">fastenal part number</th>

                    </tr>
                </thead>

                <tbody>

");
#nullable restore
#line 24 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
                     foreach (var code in item.dohItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
                           Write(code.fastenalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
                           Write(code.fastenalDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
                           Write(code.OrderQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 31 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 35 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"


        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\C#_NetCore\MyFastenalProjects\Asp.MVC.Learning\Asp.MVC.Learning\Views\Home\ViewReport.cshtml"
         
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneApproval> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a75d591db3adde9181648a90e24ece01fb5bb42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
#line 1 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\_ViewImports.cshtml"
using CoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\_ViewImports.cshtml"
using CoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a75d591db3adde9181648a90e24ece01fb5bb42", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eef958cfa2a73942bbe1330b5d72b088dccf54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h1 class=""card-title"">Mesaj Detayları</h1>
            <div class=""form-group"">
                <label>Mesaj ID</label>
                <br />
                <label class=""form-control"">");
#nullable restore
#line 14 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\MessageDetails.cshtml"
                                       Write(Html.DisplayFor(x => x.Message2ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Mesaj Konusu</label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 18 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\MessageDetails.cshtml"
                                       Write(Html.DisplayFor(x => x.Message2Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Mesaj İçeriği</label>\r\n                <textarea class=\"form-control\" style=\"height:500px\">");
#nullable restore
#line 22 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\MessageDetails.cshtml"
                                                               Write(Html.DisplayFor(x => x.Message2Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n            <a href=\"/Message/InBox\" class=\"btn btn-primary\">Mesajlara Dön</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
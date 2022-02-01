#pragma checksum "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8519a5cb2348935e7fb58f8eb43bac4f4d283d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#nullable restore
#line 1 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8519a5cb2348935e7fb58f8eb43bac4f4d283d39", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eef958cfa2a73942bbe1330b5d72b088dccf54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InboxBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h2>Gelen Kutusu</h2>
            <table class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th> # </th>
                        <th> Konu </th>
                        <th> Gönderen </th>
                        <th> Tarih </th>
                        <th> Mesajı Aç </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 26 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                        Write(item.Message2ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 27 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                        Write(item.Message2Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 28 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                        Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 29 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                         Write(((DateTime)item.Message2Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> <a");
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1141, 2);
            WriteAttributeValue("", 1101, "/Message/MessageDetails/", 1101, 24, true);
#nullable restore
#line 30 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
WriteAttributeValue("", 1125, item.Message2ID, 1125, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"> Mesajı Aç </a> </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\busra\source\repos\Intern\CoreProject\CoreProject\Views\Message\InBox.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <a href=\"/Message/InBox\" class=\"mt-4 btn btn-warning\">Yeni Mesaj Oluştur</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
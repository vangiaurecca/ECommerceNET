#pragma checksum "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60ff72dfdeacf52fb9aaad9cdcabe5df9149878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\ECommerceNETCore\ECommerceNET\Views\_ViewImports.cshtml"
using ECommerceNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ECommerceNETCore\ECommerceNET\Views\_ViewImports.cshtml"
using ECommerceNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60ff72dfdeacf52fb9aaad9cdcabe5df9149878", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd15b5cb071331f73ecf8a0ea081827a67aeea", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerceNET.Entities.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Người Dùng";
    Layout = "_FrontEnd";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- My Account Start -->\r\n<div class=\"my-account\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                   
                            <h4>Thông tin tài khoản</h4>
                            <div class=""row"">
                               
                                <div class=""col-md-6"">
                                    <input class=""form-control"" id=""hoacc"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 643, "\"", 693, 1);
#nullable restore
#line 22 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
WriteAttributeValue("", 651, Html.DisplayFor(modelItem => item.hoUser), 651, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Họ\">\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <input class=\"form-control\" id=\"tenacc\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 897, "\"", 948, 1);
#nullable restore
#line 25 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
WriteAttributeValue("", 905, Html.DisplayFor(modelItem => item.tenUser), 905, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Tên\">\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <input class=\"form-control\" id=\"sdtacc\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1153, "\"", 1204, 1);
#nullable restore
#line 28 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
WriteAttributeValue("", 1161, Html.DisplayFor(modelItem => item.sdtUser), 1161, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Số điện thoại\">\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <input class=\"form-control\" id=\"emailacc\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1421, "\"", 1444, 1);
#nullable restore
#line 31 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
WriteAttributeValue("", 1429, item.emailUser, 1429, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Email\">\r\n                                </div>\r\n                                <div class=\"col-md-12\">\r\n                                    <input class=\"form-control\" id=\"addacc\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1652, "\"", 1702, 1);
#nullable restore
#line 34 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
WriteAttributeValue("", 1660, Html.DisplayFor(modelItem => item.diaChi), 1660, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Địa chỉ"">
                                </div>
                                <div class=""col-md-12"">
                                    <button id=""submitup1"" class=""btn"">Cập nhật thông tin</button>
                                    <div id=""kqua1"" style=""color:red"">

                                    </div>
                                    <br><br>
                                </div>
                            </div>
                            <h4>Mật khẩu</h4>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <input class=""form-control"" id=""pw"" type=""password"" placeholder=""Current Password"">
                                </div>
                                <div class=""col-md-6"">
                                    <input class=""form-control"" id=""newpw"" type=""text"" placeholder=""New Password"">
                                </div>
                                <div c");
            WriteLiteral(@"lass=""col-md-6"">
                                    <input class=""form-control"" id=""repw"" type=""text"" placeholder=""Confirm Password"">
                                </div>
                                <div class=""col-md-12"">
                                    <button id=""submitup2"" class=""btn"">Xác nhận</button>
                                </div>
                                <div id=""kqua2"" style=""color:red"">

                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 63 "D:\ECommerceNETCore\ECommerceNET\Views\User\Index.cshtml"
                  
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerceNET.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591

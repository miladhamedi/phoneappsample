#pragma checksum "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7387530c1a716263b7b3198cc243b5e1e4ab3aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagContact_ListPhoneContact), @"mvc.1.0.view", @"/Views/ManagContact/ListPhoneContact.cshtml")]
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
#line 1 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\_ViewImports.cshtml"
using PhoneBookApp.Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7387530c1a716263b7b3198cc243b5e1e4ab3aae", @"/Views/ManagContact/ListPhoneContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a58705dde5cc3c9cce663aed6ec9ee60ca9254", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagContact_ListPhoneContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhoneContact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
  
    ViewData["Title"] = "  لیست شماره تماس  ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<table class=\"table\">\n    <thead class=\"thead-dark\">\n        <tr>\n            <th scope=\"col\">شماره موبایل</th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>");
#nullable restore
#line 21 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
               Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
            WriteLiteral("\n\n\n                <td>\n\n                    <a onclick=\"return confirm( \'ایا مایل ب حذف شماره تلفن هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 921, 2);
            WriteAttributeValue("", 860, "/ManagContact/DeletePhone?phonecontactid=", 860, 41, true);
#nullable restore
#line 43 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 901, item.PhoneContactId, 901, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"> حذف شماره تلفن</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 995, "\"", 1063, 2);
            WriteAttributeValue("", 1002, "/ManagContact/UpdatePhone?phonecontactid=", 1002, 41, true);
#nullable restore
#line 44 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 1043, item.PhoneContactId, 1043, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش شماره تلفن</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1204, 2);
            WriteAttributeValue("", 1147, "/ManagContact/CreatePhoneNumber?contactid=", 1147, 42, true);
#nullable restore
#line 45 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"
WriteAttributeValue("", 1189, item.ContactId, 1189, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">افزودن شماره تلفن</a>\n\n                </td>\n\n            </tr>\n");
#nullable restore
#line 50 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\ListPhoneContact.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhoneContact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
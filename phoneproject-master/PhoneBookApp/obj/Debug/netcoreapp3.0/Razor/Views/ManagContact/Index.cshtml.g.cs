#pragma checksum "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc28531ec43c1b0cb9374279dc145323eff29e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagContact_Index), @"mvc.1.0.view", @"/Views/ManagContact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc28531ec43c1b0cb9374279dc145323eff29e42", @"/Views/ManagContact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a58705dde5cc3c9cce663aed6ec9ee60ca9254", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagContact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ManagContact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
  
    ViewData["Title"] = " لیست مخاطبین";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc28531ec43c1b0cb9374279dc145323eff29e424745", async() => {
                WriteLiteral(@"
    <div class=""input-group  "">
        <input name=""search"" type=""text""  style=""background-color:white"" class=""form-control bg-light border-0 small border-right-primary  "" placeholder=""جستجو..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
        <div class=""input-group-append"">
            <button  class=""btn btn-primary"" type=""submit"" value=""Filter"" >
                <i class=""fas fa-search fa-sm""></i>
            </button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<br />



<table id=""show"" class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">نام</th>
            <th scope=""col"">نام خانوادگی</th>
            <th scope=""col"">کدملی</th>
            <th scope=""col"">شماره موبایل</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>");
#nullable restore
#line 38 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
               Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 39 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 40 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
               Write(item.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n\n\n");
#nullable restore
#line 44 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
                     foreach (var item2 in item.PhoneContacts)

                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
                         if (item.PhoneContacts.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge\"> ");
#nullable restore
#line 49 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
                                            Write(item2.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 50 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n\n\n\n                <td>\n\n                    <a onclick=\"return confirm( \'ایا مایل ب حذف کاربر هستید؟\')\"");
            BeginWriteAttribute("href", " href=\"", 1665, "\"", 1718, 2);
            WriteAttributeValue("", 1672, "/ManagContact/Delete?contactid=", 1672, 31, true);
#nullable restore
#line 60 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
WriteAttributeValue("", 1703, item.ContactId, 1703, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"> حذف کاربر</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1787, "\"", 1840, 2);
            WriteAttributeValue("", 1794, "/ManagContact/Update?contactid=", 1794, 31, true);
#nullable restore
#line 61 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
WriteAttributeValue("", 1825, item.ContactId, 1825, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">ویرایش کاربر</a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1912, "\"", 1975, 2);
            WriteAttributeValue("", 1919, "/ManagContact/ListPhoneContact?Contactid=", 1919, 41, true);
#nullable restore
#line 62 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"
WriteAttributeValue("", 1960, item.ContactId, 1960, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">ویرایش/حذف/افزودن/ شماره</a>\n\n                </td>\n\n            </tr>\n");
#nullable restore
#line 67 "F:\Projectphone\phoneproject-master\PhoneBookApp\Views\ManagContact\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591

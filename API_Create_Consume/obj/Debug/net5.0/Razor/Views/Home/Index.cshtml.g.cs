#pragma checksum "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138036e63c1920dc4828a8ec2e54a5a14084e211"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138036e63c1920dc4828a8ec2e54a5a14084e211", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<API_Create_Consume.Models.Reservation>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138036e63c1920dc4828a8ec2e54a5a14084e2112824", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Bootstrap CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We"" crossorigin=""anonymous"">

    <title>Hello, world!</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "138036e63c1920dc4828a8ec2e54a5a14084e2114220", async() => {
                WriteLiteral(@"


    <h2>All Reservations</h2>
    <a asp-action=""AddReservation"" class=""btn btn-sm btn-primary"">Add Reservation</a>
    <a asp-action=""GetReservation""  class=""btn btn-sm btn-secondary"">Get Reservation</a>

    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Start Location</th>
                <th>End Location</th>
                <th>Update</th>
                <th>Delete</th>
                <th>Detail</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
                   Write(r.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
                   Write(r.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
                   Write(r.StartLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
                   Write(r.EndLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a asp-action=\"UpdateReservation\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1476, "\"", 1496, 1);
#nullable restore
#line 44 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
WriteAttributeValue("", 1491, r.Id, 1491, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <img src=""/icon/edit.png"" />
                        </a>
                    </td>
                    <td>
                        <form asp-action=""DeleteReservation"" method=""post"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 1766, "\"", 1779, 1);
#nullable restore
#line 50 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
WriteAttributeValue("", 1774, r.Id, 1774, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ReservationId\" />\r\n                            <input type=\"image\" src=\"/icon/close.png\" />\r\n                        </form>\r\n                    </td>\r\n\r\n                    <th>\r\n\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1996, "\"", 2056, 1);
#nullable restore
#line 57 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
WriteAttributeValue("", 2003, Url.Action("GetReservation","Home",new  { id= r.Id}), 2003, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Detail</a>\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>

    <!-- Optional JavaScript; choose one of the two! -->
    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj"" crossorigin=""anonymous""></script>

    <!-- Option 2: Separate Popper and Bootstrap JS -->
    <!--
    <script src=""https://cdn.jsdelivr.net/npm/");
                WriteLiteral(@"@popperjs/core@2.9.3/dist/umd/popper.min.js"" integrity=""sha384-eMNCOe7tC1doHpGoWe/6oMVemdAVTMs2xqW4mwXrXsW0L84Iytr2wi5v2QjrP/xp"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.min.js"" integrity=""sha384-cn7l7gDp0eyniUwwAZgrzD06kc/tftFf19TOAs2zVinnD/C7E91j9yyk5//jjpt/"" crossorigin=""anonymous""></script>
    -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<API_Create_Consume.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591

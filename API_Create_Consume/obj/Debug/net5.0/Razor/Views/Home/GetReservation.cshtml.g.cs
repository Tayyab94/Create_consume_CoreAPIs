#pragma checksum "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2481f2a92d55dabcedb666d50871119060be8d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetReservation), @"mvc.1.0.view", @"/Views/Home/GetReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2481f2a92d55dabcedb666d50871119060be8d2", @"/Views/Home/GetReservation.cshtml")]
    public class Views_Home_GetReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_Create_Consume.Models.Reservation>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2481f2a92d55dabcedb666d50871119060be8d22856", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2481f2a92d55dabcedb666d50871119060be8d24252", async() => {
                WriteLiteral("\r\n\r\n\r\n    <h2>All Reservations</h2>\r\n    <\r\n    <h2>Get Reservation by Id <a asp-action=\"Index\" class=\"btn btn-sm btn-primary\">Back</a></h2>\r\n    <h3>");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
   Write(ViewBag.StatusCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
    <form method=""post"">
        <div class=""form-group"">
            <label for=""id"">Id:</label>
            <input class=""form-control"" name=""id"" />
        </div>
        <div class=""text-center panel-body"">
            <button type=""submit"" class=""btn btn-sm btn-primary"">Get Reservation</button>
        </div>
    </form>

");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <h2>Reservation</h2>
        <table class=""table table-sm table-striped table-bordered m-2"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Start Location</th>
                    <th>End Location</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 47 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
                   Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
                   Write(Model.StartLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
                   Write(Model.EndLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\APICreate_Consume\API_Create_Consume\API_Create_Consume\Views\Home\GetReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_Create_Consume.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591

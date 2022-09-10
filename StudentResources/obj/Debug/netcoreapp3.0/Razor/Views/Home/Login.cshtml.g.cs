#pragma checksum "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6506c7e04f28e5be3828662879b8013669e5f7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\_ViewImports.cshtml"
using StudentResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\_ViewImports.cshtml"
using StudentResources.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6506c7e04f28e5be3828662879b8013669e5f7ab", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72e7a3ae23f95ec793c400c38313de783e2a9ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentResources.Models.UserModel>
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
#nullable restore
#line 3 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Student Resources</h1>\r\n    <p>Please Login to Explore</p>\r\n</div>\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6506c7e04f28e5be3828662879b8013669e5f7ab3699", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <style>
        body {
            margin: 0;
            padding: 0;
            background-color: #e0ffff;
            height: 100vh;
        }

        #login .container #login-row #login-column #login-box {
            margin-top: 120px;
            max-width: 400px;
            height: 350px;
            border: 1px solid #9C9C9C;
            background-color: #EAEAEA;
        }

            #login .container #login-row #login-column #login-box #login-form {
                padding: 20px;
            }

                #login .container #login-row #login-column #login-box #login-form #register-link {
           ");
                WriteLiteral("         margin-top: -85px;\r\n                }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6506c7e04f28e5be3828662879b8013669e5f7ab5803", async() => {
                WriteLiteral(@"

    <div id=""login"">
        <div class=""container"">
            <div id=""login-row"" class=""row justify-content-center align-items-center"">
                <div id=""login-column"" class=""col-md-6"">
                    <div id=""login-box"" class=""col-md-12"">
");
#nullable restore
#line 51 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
                         using (Html.BeginForm("Verify", "Login", FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h3 class=\"text-center text-info\">Login</h3>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"username\" class=\"text-info\">Username:</label><br>\r\n                                ");
#nullable restore
#line 55 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
                           Write(Html.TextBoxFor(m => m.username, new { @class = "form-control", @placeholder = "Username", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"password\" class=\"text-info\">Password:</label><br>\r\n                                ");
#nullable restore
#line 59 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
                           Write(Html.PasswordFor(m => m.password, new { @class = "form-control", @placeholder = "Password", @required = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""remember-me"" class=""text-info""><span>Remember me</span> <span><input id=""remember-me"" name=""remember-me"" type=""checkbox""></span></label><br>
                                <input type=""submit"" name=""submit"" class=""btn btn-info btn-md"" value=""submit"">
                            </div>
");
#nullable restore
#line 65 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div style=\"color:red;\">");
#nullable restore
#line 66 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Home\Login.cshtml"
                                           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentResources.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d0ee3494d39d9b53bc52bbea9d0ed725784fa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resource_Edit), @"mvc.1.0.view", @"/Views/Resource/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0d0ee3494d39d9b53bc52bbea9d0ed725784fa2", @"/Views/Resource/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c72e7a3ae23f95ec793c400c38313de783e2a9ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Resource_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentResources.Models.ResourceModel>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0d0ee3494d39d9b53bc52bbea9d0ed725784fa23395", async() => {
                WriteLiteral("\r\n    <style>\r\n        body {\r\n            margin: 0;\r\n            padding: 0;\r\n            background-color: #e0ffff;\r\n            height: 100vh;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n<h2>Edit</h2>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Resource</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 27 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
   Write(Html.HiddenFor(model => model.ResourceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 31 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
       Write(Html.LabelFor(model => model.ResourceName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
           Write(Html.EditorFor(model => model.ResourceName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ResourceName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 39 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
       Write(Html.LabelFor(model => model.ResourceType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 41 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
           Write(Html.EditorFor(model => model.ResourceType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ResourceType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 47 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
       Write(Html.LabelFor(model => model.ResourceAvailability, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
               Write(Html.EditorFor(model => model.ResourceAvailability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 51 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.ResourceAvailability, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 62 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 65 "C:\Users\student\source\repos\StudentResources\StudentResources\Views\Resource\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentResources.Models.ResourceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

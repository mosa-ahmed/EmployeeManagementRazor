#pragma checksum "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ebe1144086d890a633ad420c51334038f854457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeeManagementRazor.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
namespace EmployeeManagementRazor.Pages.Employees
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
#line 1 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\_ViewImports.cshtml"
using EmployeeManagementRazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\_ViewImports.cshtml"
using EmployeeManagementRazor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/employees/view/{id:min(1)}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ebe1144086d890a633ad420c51334038f854457", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba6dbe48aeb78742e664aea52ddcd6cf351cfdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private global::EmployeeManagementRazor.Pages.Employees.Pages_Employees_Details.__Generated__HeadCountViewComponentTagHelper __HeadCountViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top imageThumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var photoPath = "~/images/" + (Model.Employee.PhotoPath ?? "noimage.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-center m-3\">\r\n");
#nullable restore
#line 8 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
     if (TempData["message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-8\">\r\n        <div class=\"alert alert-primary\">\r\n            ");
#nullable restore
#line 12 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-8\">\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:head-count", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ebe1144086d890a633ad420c51334038f8544576019", async() => {
            }
            );
            __HeadCountViewComponentTagHelper = CreateTagHelper<global::EmployeeManagementRazor.Pages.Employees.Pages_Employees_Details.__Generated__HeadCountViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__HeadCountViewComponentTagHelper);
#nullable restore
#line 18 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
__HeadCountViewComponentTagHelper.department = Model.Employee.Department;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("department", __HeadCountViewComponentTagHelper.department, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
#nullable restore
#line 23 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
               Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"card-body text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ebe1144086d890a633ad420c51334038f8544577943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
                                                  WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <h4>Employee ID : ");
#nullable restore
#line 28 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
                             Write(Model.Employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Email : ");
#nullable restore
#line 29 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
                       Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Department : ");
#nullable restore
#line 30 "C:\Users\NewVision\source\repos\EmployeeManagementRazor\EmployeeManagementRazor\Pages\Employees\Details.cshtml"
                            Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ebe1144086d890a633ad420c51334038f85445711199", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeManagementRazor.Pages.Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeManagementRazor.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeManagementRazor.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public EmployeeManagementRazor.Pages.Employees.DetailsModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:head-count")]
        public class __Generated__HeadCountViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__HeadCountViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public EmployeeManagementRazor.Models.Dept? department { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("HeadCount", new { department });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591

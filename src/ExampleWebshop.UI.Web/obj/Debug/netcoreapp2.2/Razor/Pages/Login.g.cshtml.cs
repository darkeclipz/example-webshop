#pragma checksum "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50fc1bd5b83712f50739b2a0279f01f25b66a65f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebshop.UI.Web.Pages.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Login.cshtml", typeof(ExampleWebshop.UI.Web.Pages.Pages_Login), null)]
namespace ExampleWebshop.UI.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\_ViewImports.cshtml"
using ExampleWebshop.UI.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fc1bd5b83712f50739b2a0279f01f25b66a65f", @"/Pages/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0447e0a416887b53d592686b35f015964925356", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "signup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(95, 82, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2>Login</h2>\r\n\r\n        ");
            EndContext();
            BeginContext(177, 907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f4899", async() => {
                BeginContext(197, 551, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label>Email address</label>
                <input type=""email"" name=""email"" class=""form-control"" required placeholder=""Enter email"">
                <small id=""emailHelp"" class=""form-text text-muted"">We'll sometimes share your email with anyone else.</small>
            </div>
            <div class=""form-group"">
                <label>Password</label>
                <input type=""password"" class=""form-control"" required name=""password"" placeholder=""Password"">
            </div>

");
                EndContext();
#line 23 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
             if(!string.IsNullOrWhiteSpace(Model.LoginError))
            {

#line default
#line hidden
                BeginContext(826, 48, true);
                WriteLiteral("                <div class=\"alert alert-danger\">");
                EndContext();
                BeginContext(875, 16, false);
#line 25 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
                                           Write(Model.LoginError);

#line default
#line hidden
                EndContext();
                BeginContext(891, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 26 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
            }

#line default
#line hidden
                BeginContext(914, 51, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 965, "\"", 989, 1);
#line 28 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
WriteAttributeValue("", 973, Model.ReturnUrl, 973, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(990, 87, true);
                WriteLiteral(" />\r\n            <button type=\"submit\" class=\"btn btn-primary\">Login</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1084, 80, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n    <div class=\"col-6\">\r\n        <h2>Signup</h2>\r\n\r\n        ");
            EndContext();
            BeginContext(1164, 4326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f8841", async() => {
                BeginContext(1246, 3507, true);
                WriteLiteral(@"

            <div class=""mb-3"">
                <label for=""email"">Email</label>
                <input type=""email"" class=""form-control"" name=""email"" id=""email"" placeholder=""you@example.com"">
                <div class=""invalid-feedback"">
                    Please enter a valid email address for shipping updates.
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""password"">Password</label>
                <input type=""password"" name=""password"" class=""form-control"" id=""password"">
                <div class=""invalid-feedback"">
                    Please enter a valid email address for shipping updates.
                </div>
            </div>

            <hr class=""mb-4"">

            <h4 class=""mb-3"">Account details</h4>

            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">First name</label>
                    <input type=""text"" class=""form-control"" name=""firstName""");
                WriteLiteral(@" id=""firstName"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""lastName"">Last name</label>
                    <input type=""text"" class=""form-control"" id=""lastName"" name=""lastName"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid last name is required.
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-8 mb-3"">
                    <label for=""streetName"">Street</label>
                    <input type=""text"" class=""form-control"" name=""streetName"" id=""streetName"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid street name is required.
                    </div>
  ");
                WriteLiteral(@"              </div>
                <div class=""col-md-4 mb-3"">
                    <label for=""houseNumber"">House number</label>
                    <input type=""text"" class=""form-control"" id=""houseNumber"" name=""houseNumber"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid house number is required.
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""postalCode"">Postal code</label>
                    <input type=""text"" class=""form-control"" name=""postalCode"" id=""postalCode"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid postal code is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""city"">City</label>
                    <input type=""text"" class=""for");
                WriteLiteral(@"m-control"" id=""city"" name=""city"" placeholder="""" value="""" required>
                    <div class=""invalid-feedback"">
                        Valid city is required.
                    </div>
                </div>
            </div>

            <div>
                <label for=""country"">Country</label>
                <select class=""custom-select d-block w-100"" id=""country"" name=""country"" required>
                    ");
                EndContext();
                BeginContext(4753, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f12995", async() => {
                    BeginContext(4770, 9, true);
                    WriteLiteral("Choose...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4788, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4810, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f14484", async() => {
                    BeginContext(4818, 11, true);
                    WriteLiteral("Netherlands");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4838, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4860, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f15767", async() => {
                    BeginContext(4868, 7, true);
                    WriteLiteral("Belgium");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4884, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4906, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50fc1bd5b83712f50739b2a0279f01f25b66a65f17045", async() => {
                    BeginContext(4914, 7, true);
                    WriteLiteral("Germany");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4930, 257, true);
                WriteLiteral(@"
                </select>
                <div class=""invalid-feedback"">
                    Please select a valid country.
                </div>
            </div>

            <hr class=""mb-4"">

            <input type=""hidden"" name=""returnUrl""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5187, "\"", 5211, 1);
#line 124 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
WriteAttributeValue("", 5195, Model.ReturnUrl, 5195, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5212, 7, true);
                WriteLiteral(" />\r\n\r\n");
                EndContext();
#line 126 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
             if(!string.IsNullOrWhiteSpace(Model.SignupError))
            {

#line default
#line hidden
                BeginContext(5298, 48, true);
                WriteLiteral("                <div class=\"alert alert-danger\">");
                EndContext();
                BeginContext(5347, 17, false);
#line 128 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
                                           Write(Model.SignupError);

#line default
#line hidden
                EndContext();
                BeginContext(5364, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 129 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Login.cshtml"
            }

#line default
#line hidden
                BeginContext(5387, 96, true);
                WriteLiteral("\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Create account\" />\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5490, 26, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExampleWebshop.UI.Web.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExampleWebshop.UI.Web.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExampleWebshop.UI.Web.Pages.LoginModel>)PageContext?.ViewData;
        public ExampleWebshop.UI.Web.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

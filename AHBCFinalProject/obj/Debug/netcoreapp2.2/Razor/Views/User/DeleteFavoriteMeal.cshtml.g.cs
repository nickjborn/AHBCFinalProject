#pragma checksum "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb781511e2d657f3258ff821208aa007525c2684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DeleteFavoriteMeal), @"mvc.1.0.view", @"/Views/User/DeleteFavoriteMeal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/DeleteFavoriteMeal.cshtml", typeof(AspNetCore.Views_User_DeleteFavoriteMeal))]
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
#line 1 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\_ViewImports.cshtml"
using AHBCFinalProject;

#line default
#line hidden
#line 2 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\_ViewImports.cshtml"
using AHBCFinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb781511e2d657f3258ff821208aa007525c2684", @"/Views/User/DeleteFavoriteMeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4177622b0e9158860a444c60c25e185bc092aa9d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DeleteFavoriteMeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FavoriteMealsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFavoriteMeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml"
  
    ViewData["Title"] = "DeleteFavoriteMeal";

#line default
#line hidden
            BeginContext(87, 162, true);
            WriteLiteral("\r\n<h1>Favorite Meals</h1>\r\n\r\n\r\n<div>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n              \r\n\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml"
             foreach (var favMeal in Model.FavoriteMeals)
            {

#line default
#line hidden
            BeginContext(323, 74, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(397, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb781511e2d657f3258ff821208aa007525c26844814", async() => {
                BeginContext(486, 16, false);
#line 26 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml"
                                                                                                           Write(favMeal.MealName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml"
                                                                                 WriteLiteral(favMeal.RecipeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(506, 77, true);
            WriteLiteral("\r\n               \r\n\r\n\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\DeleteFavoriteMeal.cshtml"
            }

#line default
#line hidden
            BeginContext(598, 46, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FavoriteMealsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

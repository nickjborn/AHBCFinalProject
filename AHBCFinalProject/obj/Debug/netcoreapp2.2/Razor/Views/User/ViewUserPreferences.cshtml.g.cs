#pragma checksum "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b35f568d7745de37cac541e570e9c5c6ca63121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewUserPreferences), @"mvc.1.0.view", @"/Views/User/ViewUserPreferences.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ViewUserPreferences.cshtml", typeof(AspNetCore.Views_User_ViewUserPreferences))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b35f568d7745de37cac541e570e9c5c6ca63121", @"/Views/User/ViewUserPreferences.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4177622b0e9158860a444c60c25e185bc092aa9d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewUserPreferences : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPreferencesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update\r\n       UserPreferences", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
  
    ViewData["Title"] = "ViewUserPreferences";

#line default
#line hidden
            BeginContext(90, 66, true);
            WriteLiteral("\r\n<h1>User Preferences</h1>\r\n\r\n\r\n<h2>Diets</h2>\r\n    Gluten-Free: ");
            EndContext();
            BeginContext(157, 16, false);
#line 11 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
            Write(Model.GlutenFree);

#line default
#line hidden
            EndContext();
            BeginContext(173, 29, true);
            WriteLiteral("\r\n    <br />\r\n    Ketogenic: ");
            EndContext();
            BeginContext(203, 15, false);
#line 13 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
          Write(Model.Ketogenic);

#line default
#line hidden
            EndContext();
            BeginContext(218, 30, true);
            WriteLiteral("\r\n    <br />\r\n    Vegetarian: ");
            EndContext();
            BeginContext(249, 16, false);
#line 15 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
           Write(Model.Vegetarian);

#line default
#line hidden
            EndContext();
            BeginContext(265, 36, true);
            WriteLiteral("\r\n    <br />\r\n    Lacto-Vegetarian: ");
            EndContext();
            BeginContext(302, 21, false);
#line 17 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
                 Write(Model.LactoVegetarian);

#line default
#line hidden
            EndContext();
            BeginContext(323, 34, true);
            WriteLiteral("\r\n    <br />\r\n    Ovo-Vegetarian: ");
            EndContext();
            BeginContext(358, 19, false);
#line 19 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
               Write(Model.OvoVegetarian);

#line default
#line hidden
            EndContext();
            BeginContext(377, 25, true);
            WriteLiteral("\r\n    <br />\r\n    Vegan: ");
            EndContext();
            BeginContext(403, 11, false);
#line 21 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
      Write(Model.Vegan);

#line default
#line hidden
            EndContext();
            BeginContext(414, 31, true);
            WriteLiteral("\r\n    <br />\r\n    Pescetarian: ");
            EndContext();
            BeginContext(446, 17, false);
#line 23 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
            Write(Model.Pescetarian);

#line default
#line hidden
            EndContext();
            BeginContext(463, 25, true);
            WriteLiteral("\r\n    <br />\r\n    Paleo: ");
            EndContext();
            BeginContext(489, 11, false);
#line 25 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
      Write(Model.Paleo);

#line default
#line hidden
            EndContext();
            BeginContext(500, 26, true);
            WriteLiteral("\r\n    <br />\r\n    Primal: ");
            EndContext();
            BeginContext(527, 12, false);
#line 27 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
       Write(Model.Primal);

#line default
#line hidden
            EndContext();
            BeginContext(539, 27, true);
            WriteLiteral("\r\n    <br />\r\n    Whole30: ");
            EndContext();
            BeginContext(567, 13, false);
#line 29 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
        Write(Model.Whole30);

#line default
#line hidden
            EndContext();
            BeginContext(580, 54, true);
            WriteLiteral("\r\n    <br />\r\n\r\n    <h2>Intolerances</h2>\r\n    Dairy: ");
            EndContext();
            BeginContext(635, 11, false);
#line 33 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
      Write(Model.Dairy);

#line default
#line hidden
            EndContext();
            BeginContext(646, 23, true);
            WriteLiteral("\r\n    <br />\r\n    Egg: ");
            EndContext();
            BeginContext(670, 9, false);
#line 35 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
    Write(Model.Egg);

#line default
#line hidden
            EndContext();
            BeginContext(679, 26, true);
            WriteLiteral("\r\n    <br />\r\n    Gluten: ");
            EndContext();
            BeginContext(706, 12, false);
#line 37 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
       Write(Model.Gluten);

#line default
#line hidden
            EndContext();
            BeginContext(718, 25, true);
            WriteLiteral("\r\n    <br />\r\n    Grain: ");
            EndContext();
            BeginContext(744, 11, false);
#line 39 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
      Write(Model.Grain);

#line default
#line hidden
            EndContext();
            BeginContext(755, 26, true);
            WriteLiteral("\r\n    <br />\r\n    Peanut: ");
            EndContext();
            BeginContext(782, 12, false);
#line 41 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
       Write(Model.Peanut);

#line default
#line hidden
            EndContext();
            BeginContext(794, 27, true);
            WriteLiteral("\r\n    <br />\r\n    Seafood: ");
            EndContext();
            BeginContext(822, 13, false);
#line 43 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
        Write(Model.Seafood);

#line default
#line hidden
            EndContext();
            BeginContext(835, 26, true);
            WriteLiteral("\r\n    <br />\r\n    Sesame: ");
            EndContext();
            BeginContext(862, 12, false);
#line 45 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
       Write(Model.Sesame);

#line default
#line hidden
            EndContext();
            BeginContext(874, 29, true);
            WriteLiteral("\r\n    <br />\r\n    Shellfish: ");
            EndContext();
            BeginContext(904, 15, false);
#line 47 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
          Write(Model.Shellfish);

#line default
#line hidden
            EndContext();
            BeginContext(919, 23, true);
            WriteLiteral("\r\n    <br />\r\n    Soy: ");
            EndContext();
            BeginContext(943, 9, false);
#line 49 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
    Write(Model.Soy);

#line default
#line hidden
            EndContext();
            BeginContext(952, 27, true);
            WriteLiteral("\r\n    <br />\r\n    Sulfite: ");
            EndContext();
            BeginContext(980, 13, false);
#line 51 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
        Write(Model.Sulfite);

#line default
#line hidden
            EndContext();
            BeginContext(993, 28, true);
            WriteLiteral("\r\n    <br />\r\n    Tree Nut: ");
            EndContext();
            BeginContext(1022, 13, false);
#line 53 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
         Write(Model.TreeNut);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 25, true);
            WriteLiteral("\r\n    <br />\r\n    Wheat: ");
            EndContext();
            BeginContext(1061, 11, false);
#line 55 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
      Write(Model.Wheat);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 40, true);
            WriteLiteral("\r\n    <br />\r\n    Excluded Ingredients: ");
            EndContext();
            BeginContext(1113, 25, false);
#line 57 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
                     Write(Model.ExcludedIngredients);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 20, true);
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
            EndContext();
            BeginContext(1158, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b35f568d7745de37cac541e570e9c5c6ca6312113090", async() => {
                BeginContext(1256, 56, true);
                WriteLiteral("\r\n        <button>Update User Preferences</button>\r\n    ");
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
#line 61 "C:\Users\green\source\repos\AHBCFinalProject-1\AHBCFinalProject\Views\User\ViewUserPreferences.cshtml"
                          WriteLiteral(Model.UserId);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPreferencesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6411562c9ed1c0da79b02d921ce9c9f6518bb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieEdit), @"mvc.1.0.view", @"/Views/Movie/MovieEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/MovieEdit.cshtml", typeof(AspNetCore.Views_Movie_MovieEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6411562c9ed1c0da79b02d921ce9c9f6518bb6", @"/Views/Movie/MovieEdit.cshtml")]
    public class Views_Movie_MovieEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcModel.movieData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/sub.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
  
    ViewBag.Title = "MovieEdit";
    Layout = null;

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 73, true);
            WriteLiteral("\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n");
            EndContext();
            BeginContext(163, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb6411562c9ed1c0da79b02d921ce9c9f6518bb64613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(234, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb6411562c9ed1c0da79b02d921ce9c9f6518bb65948", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(302, 24, true);
            WriteLiteral("\r\n\r\n<div id=\"content\">\r\n");
            EndContext();
#line 13 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
     using (Html.BeginForm("MovieEdit", "Movie", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {
        

#line default
#line hidden
            BeginContext(451, 28, false);
#line 15 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(481, 236, true);
            WriteLiteral("        <table class=\"niunantab\">\r\n            <tbody>\r\n\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Movie name：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(718, 67, false);
#line 24 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mname, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(837, 47, false);
#line 25 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mname));

#line default
#line hidden
            EndContext();
            BeginContext(884, 301, true);
            WriteLiteral(@"</span>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        Image：
                    </td>
                    <td>
                        <input type=""file"" name=""uploadfile"" />
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1185, "\"", 1210, 2);
            WriteAttributeValue("", 1191, "/upload/", 1191, 8, true);
#line 34 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
WriteAttributeValue("", 1199, Model.mpic, 1199, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1211, 63, true);
            WriteLiteral(" style=\"width:123px; height:96px;\" />\r\n                        ");
            EndContext();
            BeginContext(1275, 35, false);
#line 35 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.HiddenFor(model => model.mpic));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(1362, 46, false);
#line 36 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mpic));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 975, true);
            WriteLiteral(@"</span>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        Genre：
                    </td>
                    <td>
                        <select name=""mtype"" style=""height:35px;"">
                            <option>All</option>
                            <option>Romance</option>
                            <option>Science fiction</option>
                            <option>Comedy</option>
                            <option>Military</option>
                            <option>Horror</option>
                            <option>Action</option>
                            <option>Cartoon</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        Release time：
                    </td>
                    <td>
                        ");
            EndContext();
            BeginContext(2384, 68, false);
#line 61 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mmtime, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(2504, 48, false);
#line 62 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mmtime));

#line default
#line hidden
            EndContext();
            BeginContext(2552, 238, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Description：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2791, 68, false);
#line 70 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mpress, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(2911, 48, false);
#line 71 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mpress));

#line default
#line hidden
            EndContext();
            BeginContext(2959, 232, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Score：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3192, 68, false);
#line 79 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mscore, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(3260, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(3312, 48, false);
#line 80 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mscore));

#line default
#line hidden
            EndContext();
            BeginContext(3360, 235, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Director：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3596, 70, false);
#line 88 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.maddress, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(3666, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(3718, 50, false);
#line 89 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.maddress));

#line default
#line hidden
            EndContext();
            BeginContext(3768, 235, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Starring：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4004, 67, false);
#line 97 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mting, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(4071, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(4123, 47, false);
#line 98 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mting));

#line default
#line hidden
            EndContext();
            BeginContext(4170, 234, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Version：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4405, 68, false);
#line 106 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.mbrand, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(4473, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(4525, 48, false);
#line 107 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.mbrand));

#line default
#line hidden
            EndContext();
            BeginContext(4573, 1911, true);
            WriteLiteral(@"</span>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        Region：
                    </td>
                    <td>
                        <select name=""mcc"" style=""height:35px;"">
                            <option>All</option>
                            <option>Mainland China</option>
                            <option>Japan and Korea</option>
                            <option>Europe and America</option>
                            <option>United Kingdom</option>
                            <option>Thailand</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        Release time：
                    </td>
                    <td>
                        <select name=""mprice"" style=""height:35px;"">
                            <option>2010</option>
                            <optio");
            WriteLiteral(@"n>2011</option>
                            <option>2012</option>
                            <option>2013</option>
                            <option>2014</option>
                            <option>2015</option>
                            <option>2016</option>
                            <option>2017</option>
                            <option>2018</option>
                            <option>2019</option>
                            <option>2020</option>
                            <option>2021</option>
                            <option>2022</option>
                            <option>2023</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class=""left_td"">
                        State：
                    </td>
                    <td>
                        ");
            EndContext();
            BeginContext(6485, 68, false);
#line 153 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.status, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(6553, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(6605, 48, false);
#line 154 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(6653, 234, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"left_td\">\r\n                        Comment：\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(6888, 69, false);
#line 162 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                   Write(Html.TextBoxFor(model => model.turnurl, new { @class = "inputtext" }));

#line default
#line hidden
            EndContext();
            BeginContext(6957, 51, true);
            WriteLiteral("\r\n                        <span style=\"color:red;\">");
            EndContext();
            BeginContext(7009, 49, false);
#line 163 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
                                            Write(Html.ValidationMessageFor(model => model.turnurl));

#line default
#line hidden
            EndContext();
            BeginContext(7058, 358, true);
            WriteLiteral(@"</span>
                    </td>
                </tr>

                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <input type=""submit"" class=""btn"" value=""Save"" />
                    </td>
                </tr>
            </tbody>
        </table>
");
            EndContext();
#line 177 "C:\Users\Hanwei Jiang\Desktop\476\Web\Web\Views\Movie\MovieEdit.cshtml"
    }

#line default
#line hidden
            BeginContext(7423, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcModel.movieData> Html { get; private set; }
    }
}
#pragma warning restore 1591
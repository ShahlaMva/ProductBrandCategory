#pragma checksum "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d68731a722720bfa9bce59e6254e30096c21514e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\_ViewImports.cshtml"
using Watch.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\_ViewImports.cshtml"
using Watch.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68731a722720bfa9bce59e6254e30096c21514e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e43c4b1c46f7bd31fa18e5213028e0aa554752", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" heartbeat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/choce_watch1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/gallery/choce_watch2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 112, true);
            WriteLiteral("\r\n<main>\r\n    <!--? slider Area Start -->\r\n    <div class=\"slider-area \">\r\n        <div class=\"slider-active\">\r\n");
            EndContext();
#line 10 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
             foreach (Slider slider in @Model.Sliders)
            {

#line default
#line hidden
            BeginContext(247, 473, true);
            WriteLiteral(@"                <div class=""single-slider slider-height d-flex align-items-center slide-bg"">
                    <div class=""container"">
                        <div class=""row justify-content-between align-items-center"">
                            <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-8"">
                                <div class=""hero__caption"">
                                    <h1 data-animation=""fadeInLeft"" data-delay="".4s"" data-duration=""2000ms"">");
            EndContext();
            BeginContext(721, 12, false);
#line 17 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
                                                                                                       Write(slider.Title);

#line default
#line hidden
            EndContext();
            BeginContext(733, 114, true);
            WriteLiteral("</h1>\r\n                                    <p data-animation=\"fadeInLeft\" data-delay=\".7s\" data-duration=\"2000ms\">");
            EndContext();
            BeginContext(848, 11, false);
#line 18 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
                                                                                                      Write(slider.Text);

#line default
#line hidden
            EndContext();
            BeginContext(859, 644, true);
            WriteLiteral(@"</p>
                                    <!-- Hero-btn -->
                                    <div class=""hero__btn"" data-animation=""fadeInLeft"" data-delay="".8s"" data-duration=""2000ms"">
                                        <a href=""industries.html"" class=""btn hero-btn"">Shop Now</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-xl-3 col-lg-3 col-md-4 col-sm-4 d-none d-sm-block"">
                                <div class=""hero__img"" data-animation=""bounceIn"" data-delay="".4s"">
                                    ");
            EndContext();
            BeginContext(1503, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "59a4fc96240c4a84b4c4d1d454fb273a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1513, "~/assets/img/hero/", 1513, 18, true);
#line 27 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1531, slider.Image, 1531, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1572, 162, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 33 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"


            }

#line default
#line hidden
            BeginContext(1753, 571, true);
            WriteLiteral(@"            <!-- Single Slider -->
            <!-- Single Slider -->

        </div>
    </div>
    <!-- slider Area End-->
    <!-- ? New Product Start -->
    <section class=""new-product-area section-padding30"">
        <div class=""container"">
            <!-- Section tittle -->
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""section-tittle mb-70"">
                        <h2>New Arrivals</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
            EndContext();
            BeginContext(3054, 408, true);
            WriteLiteral(@"
            </div>
        </div>
    </section>
    <!--  New Product End -->
    <!--? Gallery Area Start -->
    <div class=""gallery-area"">
        <div class=""container-fluid p-0 fix"">
            <div class=""row"">
                <div class=""col-xl-6 col-lg-4 col-md-6 col-sm-6"">
                    <div class=""single-gallery mb-30"">
                        <div class=""gallery-img big-img""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3462, "\"", 3550, 4);
            WriteAttributeValue("", 3470, "background-image:", 3470, 17, true);
            WriteAttributeValue(" ", 3487, "url(assets/img/gallery/", 3488, 24, true);
#line 80 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
WriteAttributeValue("", 3511, Model.WatchImages.ElementAt(0).Image, 3511, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 3548, ");", 3548, 2, true);
            EndWriteAttribute();
            BeginContext(3551, 240, true);
            WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-xl-3 col-lg-4 col-md-6 col-sm-6\">\r\n                    <div class=\"single-gallery mb-30\">\r\n                        <div class=\"gallery-img big-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3791, "\"", 3879, 4);
            WriteAttributeValue("", 3799, "background-image:", 3799, 17, true);
            WriteAttributeValue(" ", 3816, "url(assets/img/gallery/", 3817, 24, true);
#line 85 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
WriteAttributeValue("", 3840, Model.WatchImages.ElementAt(1).Image, 3840, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 3877, ");", 3877, 2, true);
            EndWriteAttribute();
            BeginContext(3880, 366, true);
            WriteLiteral(@"></div>
                    </div>
                </div>
                <div class=""col-xl-3 col-lg-4 col-md-12"">
                    <div class=""row"">
                        <div class=""col-xl-12 col-lg-12 col-md-6 col-sm-6"">
                            <div class=""single-gallery mb-30"">
                                <div class=""gallery-img small-img""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4246, "\"", 4334, 4);
            WriteAttributeValue("", 4254, "background-image:", 4254, 17, true);
            WriteAttributeValue(" ", 4271, "url(assets/img/gallery/", 4272, 24, true);
#line 92 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
WriteAttributeValue("", 4295, Model.WatchImages.ElementAt(2).Image, 4295, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 4332, ");", 4332, 2, true);
            EndWriteAttribute();
            BeginContext(4335, 285, true);
            WriteLiteral(@"></div>
                            </div>
                        </div>
                        <div class=""col-xl-12 col-lg-12  col-md-6 col-sm-6"">
                            <div class=""single-gallery mb-30"">
                                <div class=""gallery-img small-img""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4620, "\"", 4708, 4);
            WriteAttributeValue("", 4628, "background-image:", 4628, 17, true);
            WriteAttributeValue(" ", 4645, "url(assets/img/gallery/", 4646, 24, true);
#line 97 "C:\Users\Code\Desktop\P116\Asp .Net Core\07.08.2020-AspFrontToBack\FrontToBack\Watch\Watch\Views\Home\Index.cshtml"
WriteAttributeValue("", 4669, Model.WatchImages.ElementAt(3).Image, 4669, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 4706, ");", 4706, 2, true);
            EndWriteAttribute();
            BeginContext(4709, 867, true);
            WriteLiteral(@"></div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <!-- Gallery Area End -->
    <!--? Popular Items Start -->
    <div class=""popular-items section-padding30"">
        <div class=""container"">
            <!-- Section tittle -->
            <div class=""row justify-content-center"">
                <div class=""col-xl-7 col-lg-8 col-md-10"">
                    <div class=""section-tittle mb-70 text-center"">
                        <h2>Popular Items</h2>
                        <p>Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida.</p>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
            EndContext();
            BeginContext(6306, 2000, true);
            WriteLiteral(@"                
               
            </div>
            <!-- Button -->
            <div class=""row justify-content-center"">
                <div class=""room-btn pt-70"">
                    <a href=""catagori.html"" class=""btn view-btn1"">View More Products</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Popular Items End -->
    <!--? Video Area Start -->
    <div class=""video-area"">
        <div class=""container-fluid"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <div class=""video-wrap"">
                        <div class=""play-btn ""><a class=""popup-video"" href=""https://www.youtube.com/watch?v=KMc6DyEJp04""><i class=""fas fa-play""></i></a></div>
                    </div>
                </div>
            </div>
            <!-- Arrow -->
            <div class=""thumb-content-box"">
                <div class=""thumb-content"">
                    <h3>Next Video</h3>
                 ");
            WriteLiteral(@"   <a href=""#""> <i class=""flaticon-arrow""></i></a>
                </div>
            </div>
        </div>
    </div>
    <!-- Video Area End -->
    <!--? Watch Choice  Start-->
    <div class=""watch-area section-padding30"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-between padding-130"">
                <div class=""col-lg-5 col-md-6"">
                    <div class=""watch-details mb-40"">
                        <h2>Watch of Choice</h2>
                        <p>Enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse.</p>
                        <a href=""shop.html"" class=""btn"">Show Watches</a>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-10"">
                    <div class=""choice-watch-img mb-40"">
                        ");
            EndContext();
            BeginContext(8306, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82b2408373684ae2b090031136356403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8362, 289, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""row align-items-center justify-content-between"">
                <div class=""col-lg-6 col-md-6 col-sm-10"">
                    <div class=""choice-watch-img mb-40"">
                        ");
            EndContext();
            BeginContext(8651, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0ec88115d0744b4bd3f6638db54c71a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8707, 2103, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-lg-5 col-md-6"">
                    <div class=""watch-details mb-40"">
                        <h2>Watch of Choice</h2>
                        <p>Enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse.</p>
                        <a href=""shop.html"" class=""btn"">Show Watches</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Watch Choice  End-->
    <!--? Shop Method Start-->
    <div class=""shop-method-area"">
        <div class=""container"">
            <div class=""method-wrapper"">
                <div class=""row d-flex justify-content-between"">
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i class=""ti-package""></i>
                        ");
            WriteLiteral(@"    <h6>Free Shipping Method</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i class=""ti-unlock""></i>
                            <h6>Secure Payment System</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                    <div class=""col-xl-4 col-lg-4 col-md-6"">
                        <div class=""single-method mb-40"">
                            <i class=""ti-reload""></i>
                            <h6>Secure Payment System</h6>
                            <p>aorem ixpsacdolor sit ameasecur adipisicing elitsf edasd.</p>
                        </div>
                    </div>
                </div>
            </div>
        </d");
            WriteLiteral("iv>\r\n    </div>\r\n    <!-- Shop Method End-->\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

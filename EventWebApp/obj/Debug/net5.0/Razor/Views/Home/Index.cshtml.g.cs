#pragma checksum "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80dd48f345dbd664fdea254b20285a2e195fada6"
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
#nullable restore
#line 1 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/_ViewImports.cshtml"
using EventWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/_ViewImports.cshtml"
using EventWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80dd48f345dbd664fdea254b20285a2e195fada6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2b5e3c8fb92c42263536eb9d341be5ded86bdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventWebApp.Models.ViewModels.EventsInPastAndFutureVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("participant-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/plus.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/remove.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Avaleht";
    int rowNo1 = 0;
    int rowNo2 = 0;
    int noOfAttendees = 0;
    int n = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""jumbotron col-sm-6 header-1"">
        <div class=""container"">
            <p class=""lead"">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
        </div>
    </div>
    <div class=""jumbotron col-sm-6 header-2"">
        <div class=""container"">
        </div>
    </div>
</div>

<div class=""row event-row"">
    <div class=""container-fluid""></div>
    <div class=""card col card-1"">
        <div class=""card-header"">
            Tulevased üritused
        </div>
        <div class=""card-body"">
");
#nullable restore
#line 30 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
             if (Model.EventsFuture.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-sm\">\n                    <tbody>\n");
#nullable restore
#line 34 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                         foreach (var obj in Model.EventsFuture)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td scope=\"row\">");
#nullable restore
#line 37 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                            Write(rowNo1 += 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n                                <td>\n                                    <div class=\"row\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dd48f345dbd664fdea254b20285a2e195fada68878", async() => {
                WriteLiteral("\n                                            ");
#nullable restore
#line 41 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                       Write(obj.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                                                                                                  WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </td>\n                                <td>");
#nullable restore
#line 45 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                               Write(obj.StartDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 46 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                  noOfAttendees = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                 foreach (var att in Model.Attendees.Where(a => a.EventId == obj.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                     if (@att.ParticipantCount == null)
                                    {
                                        noOfAttendees += 1;
                                    }
                                    else
                                    {
                                        n = (int)att.ParticipantCount;
                                        noOfAttendees += n;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                     
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 60 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                 if (noOfAttendees == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\n                                        -\n                                    </td>\n");
#nullable restore
#line 65 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\n                                        ");
#nullable restore
#line 70 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                   Write(noOfAttendees);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n");
#nullable restore
#line 72 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <td>
                                    <div class=""row"">
                                        <div class=""tooltip2"">
                                            <span class=""tooltiptext2"">Lisa osavõtja</span>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3171, "\"", 3237, 1);
#nullable restore
#line 78 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 3178, Url.Action("Create", "Attendee", new { eventId = obj.Id }), 3178, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <div class=\"add-obj\">\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80dd48f345dbd664fdea254b20285a2e195fada615544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </a>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <div class=""row"">
                                        <div class=""tooltip2"">
                                            <span class=""tooltiptext2"">Kustuta üritus</span>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dd48f345dbd664fdea254b20285a2e195fada617170", async() => {
                WriteLiteral("\n                                                <button type=\"submit\" class=\"delete-obj\">\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80dd48f345dbd664fdea254b20285a2e195fada617572", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                </button>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                                                                               WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 99 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 103 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <p class=\"index-table-p\">Tulevased üritused puuduvad</p>\n");
#nullable restore
#line 108 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <div>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dd48f345dbd664fdea254b20285a2e195fada622221", async() => {
                WriteLiteral("\n                    LISA ÜRITUS\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n\n        </div>\n    </div>\n    <div class=\"card col card-2\">\n        <div class=\"card-header\">\n            Toimunud üritused\n        </div>\n        <div class=\"card-body\">\n");
#nullable restore
#line 124 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
             if (Model.EventsPast.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-sm\">\n                    <tbody>\n");
#nullable restore
#line 128 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                         foreach (var obj in Model.EventsPast)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td scope=\"row\">");
#nullable restore
#line 131 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                            Write(rowNo2 += 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n                                <td>");
#nullable restore
#line 132 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                               Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 133 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                               Write(obj.StartDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 134 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                  noOfAttendees = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                 foreach (var att in Model.Attendees.Where(a => a.EventId == obj.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                     if (@att.ParticipantCount == null)
                                    {
                                        noOfAttendees += 1;
                                    }
                                    else
                                    {

                                        n = (int)att.ParticipantCount;
                                        noOfAttendees += n;

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 150 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                 if (noOfAttendees == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\n                                        -\n                                    </td>\n");
#nullable restore
#line 155 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\n                                        ");
#nullable restore
#line 160 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                   Write(noOfAttendees);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n");
#nullable restore
#line 162 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\n                                    <div class=\"row\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80dd48f345dbd664fdea254b20285a2e195fada628209", async() => {
                WriteLiteral("\n                                            OSAVÕTJAD\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
                                                                                                                  WriteLiteral(obj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 171 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 175 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\n                <p class=\"index-table-p\">Toimunud üritused puuduvad</p>\n");
#nullable restore
#line 180 "/Users/oskar/Desktop/github/EventWebApp/EventWebApp/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventWebApp.Models.ViewModels.EventsInPastAndFutureVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

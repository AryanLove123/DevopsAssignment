#pragma checksum "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4888d6cc198c92638bbaf7cec1e4bbc8b1899ad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EventsInvitedTo), @"mvc.1.0.view", @"/Views/Event/EventsInvitedTo.cshtml")]
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
#line 1 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\_ViewImports.cshtml"
using BookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\_ViewImports.cshtml"
using BookApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4888d6cc198c92638bbaf7cec1e4bbc8b1899ad4", @"/Views/Event/EventsInvitedTo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d0b2bfded0cf59895d98bcaac42a3366aec6cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_EventsInvitedTo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml"
  
    ViewData["Title"] = "Events invited";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div class=\"h-100 p-5 bg-light border rounded-3\">\r\n        <h2 class=\"text-center\">Events Invited To</h2>\r\n");
#nullable restore
#line 9 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml"
         foreach (var Event in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col py-2\">\r\n                <div class=\"p-2 border bg-light form-inline\" style=\"justify-content:space-between\">\r\n                    <h6 class=\"px-2\">");
#nullable restore
#line 13 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml"
                                Write(Event.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <a class=\"btn btn-outline-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 524, "\"", 592, 1);
#nullable restore
#line 14 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml"
WriteAttributeValue("", 531, Url.Action("ViewEvent","Event",new {eventId=Event.EventId }), 531, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Details</a>\r\n                   \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\lovekesharya\OneDrive - Nagarro\Desktop\AWSGIT\lovekesh-kumar-arya\MVC Assignment Resubmission\BookApp\BookApp\Views\Event\EventsInvitedTo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

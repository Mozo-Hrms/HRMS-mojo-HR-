#pragma checksum "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f4a0e389916dd55c508dca9b06cd1888661b299b9ec6c2a88d7ecebbeb0e643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Message), @"mvc.1.0.view", @"/Views/Shared/_Message.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\_ViewImports.cshtml"
using SmartH2RCore.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8f4a0e389916dd55c508dca9b06cd1888661b299b9ec6c2a88d7ecebbeb0e643", @"/Views/Shared/_Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"40e21cc8aa428901517b537ec0aa48eab916f283bf3d7731bc7b9bafe3204a71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml"
 if ((string)TempData["Message"] != null && (string)TempData["Message"] != "")
{
    if ((bool)TempData["Success"] == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            $(function () {\r\n                Lobibox.notify(\"success\", {\r\n                    title: \'HRMS\',\r\n                    position: \"top right\",\r\n                    msg: \"");
#nullable restore
#line 10 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml"
                     Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                });\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 14 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml"
    }
    if ((bool)TempData["Success"] == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            Lobibox.notify(\"error\", {\r\n                    title: \'HRMS\',\r\n                    msg: \"");
#nullable restore
#line 20 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml"
                     Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    position: \"top right\"\r\n                });\r\n        </script>\r\n");
#nullable restore
#line 24 "F:\HRMS_netcore\SmartH2R\src\SmartH2RCore.Web\Views\Shared\_Message.cshtml"
    }
    TempData["Message"] = null;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

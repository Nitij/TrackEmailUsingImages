#pragma checksum "C:\Users\nitij\source\repos\TrackEmail\TrackEmail\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298a5bbdb36bc5437587aeaf1dbc8aebe158b476"
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
#line 1 "C:\Users\nitij\source\repos\TrackEmail\TrackEmail\Views\_ViewImports.cshtml"
using TrackEmail;

#line default
#line hidden
#line 2 "C:\Users\nitij\source\repos\TrackEmail\TrackEmail\Views\_ViewImports.cshtml"
using TrackEmail.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298a5bbdb36bc5437587aeaf1dbc8aebe158b476", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1b0db9fa904b82784b57da12b9ee0e6b3336ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nitij\source\repos\TrackEmail\TrackEmail\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 443, true);
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8"" src=""https://code.jquery.com/jquery-1.12.4.min.js""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.js""></script>

<h2>Email Open Status</h2>
<table id=""content""></table>

<script>
    var users = JSON.parse('");
            EndContext();
            BeginContext(489, 27, false);
#line 14 "C:\Users\nitij\source\repos\TrackEmail\TrackEmail\Views\Home\Index.cshtml"
                       Write(Html.Raw(ViewData["Users"]));

#line default
#line hidden
            EndContext();
            BeginContext(516, 297, true);
            WriteLiteral(@"');
    var userTableData = [];
    users.forEach(function (user, idx) {
        userTableData.push([user.Name, user.EmailOpened]);
    });

    $('#content').DataTable(
    {
        data: userTableData,
        columns: [{ title: ""Name"" }, { title: ""Email Opened"" }]
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6883a38b1be688147570cca6916ca38aabe7c882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_PaymentCheckoutUrl), @"mvc.1.0.view", @"/Views/Payment/PaymentCheckoutUrl.cshtml")]
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
#line 1 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
using uttarakhand_project_front.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6883a38b1be688147570cca6916ca38aabe7c882", @"/Views/Payment/PaymentCheckoutUrl.cshtml")]
    public class Views_Payment_PaymentCheckoutUrl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PayUViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<form name=\"payment\" id=\"payment\" method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 112, "\"", 139, 1);
#nullable restore
#line 4 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
WriteAttributeValue("", 121, Model.CheckoutUrl, 121, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 5 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
      
        if (Model.NameValue != null && Model.NameValue.Count > 0)
        {
         
            SortedDictionary<string, string> sortedDict = uttarakhand_project_front.Services.HelperService.SortNameValueCollection(Model.NameValue);

            foreach (KeyValuePair<string, string>    p in sortedDict)
            {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 534, "\"", 547, 1);
#nullable restore
#line 13 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
WriteAttributeValue("", 541, p.Key, 541, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 548, "\"", 564, 1);
#nullable restore
#line 13 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
WriteAttributeValue("", 556, p.Value, 556, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />                \r\n");
#nullable restore
#line 14 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
            }
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1> Error!</h1>\r\n            <p> Invalid response </p>\r\n");
#nullable restore
#line 21 "D:\PSEB Project Live\KuEntrance\uttarakhand-project-front-master\Views\Payment\PaymentCheckoutUrl.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</form>
<div class=""row"" style=""text-align:center"">
    <div class=""small-12 large-12"">
        <h2 class=""text-center"">Please wait, redirecting to process payment..</h2>
    </div>
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
<script>
    $(""#payment"").submit();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayUViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

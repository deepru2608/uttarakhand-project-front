#pragma checksum "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48e72447111fe0a6587b6c3b46ebfdec403cf30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_ViewPaymentSlip), @"mvc.1.0.view", @"/Views/Payment/ViewPaymentSlip.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48e72447111fe0a6587b6c3b46ebfdec403cf30", @"/Views/Payment/ViewPaymentSlip.cshtml")]
    public class Views_Payment_ViewPaymentSlip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<uttarakhand_project_front.Models.PaymentSuccessModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
  
    ViewBag.Title = "View Slip";
    //Layout = "~/Views/Shared/_Card_Header.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    table {
        border-collapse: separate;
    }

    th {
        background-color: #4287f5;
        color: white;
    }

    th,
    td {
        width: 150px;
        text-align: center;
        border: 1px solid black;
        padding: 5px;
    }

    h2 {
        color: #4287f5;
    }
</style>
");
#nullable restore
#line 29 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
  

    if (Model.PaymentStatus.ToString().ToLower() == "success")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table width=""600"" align=""center"" border=""1"">
        <tr>
            <td align=""left""><img src=""https://kuentrance.co.in/Images/Kumaun-University-job.png"" height=""75"" alt=""Kumaun"" /></td>
            <td align=""right""><img src=""https://kuentrance.co.in/Images/hdfc.jpg"" width=""200"" height=""75"" alt=""HDFC"" /></td>
        </tr>
        <tr>
            <td align=""center"" colspan=""2""><h4>Kumaun University</h4></td>
        </tr>
        <tr>
            <td colspan=""2"">
                <h4>Registration</h4>
                <p>Thank you for your payment with the details below:</p>
            </td>
        </tr>

        <tr>
            <td colspan=""2""><h3>Transaction Acknowledgment Slip</h3></td>
        </tr>
        <tr>
            <td>Payment Status : </td>
            <td class=""text-primary""><b>");
#nullable restore
#line 53 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
                                   Write(Model.PaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Payment Id : </td>\r\n            <td class=\"text-primary\">");
#nullable restore
#line 57 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
                                Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Transaction Id : </td>\r\n            <td class=\"text-primary\">");
#nullable restore
#line 61 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
                                Write(Model.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Reference Number : </td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
           Write(Model.ReferenceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Payment Date: </td>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
           Write(Model.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Payment Amount: </td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
           Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 76 "C:\Users\deepa\Downloads\KU_Solution_30Aug2020_12AM\KU_Solution_30Aug2020_12AM\Views\Payment\ViewPaymentSlip.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"text-align:center\">\r\n        <br />  <input type=\"button\" value=\"Print\" class=\"btn\" onclick=\"window.print()\" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n");
            WriteLiteral("    </p>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<uttarakhand_project_front.Models.PaymentSuccessModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

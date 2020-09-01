using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.ViewModels;

namespace uttarakhand_project_front.Services
{
    public interface IPaymentService
    {
        string GetPayU_SALT();
        string GetPayU_Merhant_Key();

        string Generatehash512(string text);
        string GetPayU_PAYMENT_URL();
        string GetPayU_RETURN_URL();
        string GetPayU_CANCEL_URL();

        string GetPayU_HashSequence();



        #region Payment 
        Task<Payment> InsertPaymentMasterAsync(string Id);
        Task<Payment> GetPaymentMasterByOrderIdAsync(string Id);

        Task<List<Payment>> GetAllPaymentMasterByRefNo(string Id);

        Task<Payment> CheckPaymentPaidAgainstRefNo(string Id);
        Task<Payment> UpdatePaymentMasterByOrderIdAsync(string OrderId, PaymentSuccessModel paymentSuccessModel);
        #endregion

    }
}

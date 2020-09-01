using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using uttarakhand_project_front.Data;
using uttarakhand_project_front.Models;
using uttarakhand_project_front.Services;

namespace uttarakhand_project_front.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DapperService _dapperService;
        private readonly ICenterService _centerService;
        private readonly FrontAppDbContext _dbContext;

        public ServiceController(DapperService dapperService, ICenterService centerService, FrontAppDbContext dbContext)
        {
            _dapperService = dapperService;
            _centerService = centerService;
            _dbContext = dbContext;
        }
        
        public async Task<IActionResult> PrintFinalDownload(string id)
        {
            var registrationData = await _centerService.GetRegistrationDetailsByRefIdAsync(id);
            registrationData.PaymentDetail = await _dbContext.PaymentMaster.Where(s => s.RefNo.ToUpper().Trim() == id.ToUpper().Trim() && s.PaidStatus == 1).FirstOrDefaultAsync();
            return View(registrationData);
        }
    }
}
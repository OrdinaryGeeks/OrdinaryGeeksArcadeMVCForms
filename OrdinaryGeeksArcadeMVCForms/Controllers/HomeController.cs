using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using OrdinaryGeeksArcadeMVCForms.Models;

    using OrdinaryGeeksArcadeMVCForms.Helper;

namespace OrdinaryGeeksArcadeMVCForms.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {


        private readonly IConfiguration _configuration;
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
     
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Configure()
        {

            return View();
        }
        [Authorize]
        [HttpGet()]
        public async Task<string> GetUserAccessToken()
        {
            try
            {
                return await SSOAuthHelper.GetAccessTokenOnBehalfUserAsync(_configuration, _httpClientFactory, _httpContextAccessor);
            }
            catch (Exception)
            {
                return null;
            }
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
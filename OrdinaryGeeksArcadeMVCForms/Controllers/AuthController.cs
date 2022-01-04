using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Extensions.Configuration;



namespace OrdinaryGeeksArcadeMVCForms.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        public AuthController(
         IConfiguration configuration)
        {
            _configuration = configuration;
        }


        
   
        public ActionResult Start()
        {
            ViewBag.AzureClientId = _configuration["AzureAd:ClientId"];
            return View();
        }

        /// <summary>
        /// Authentication End
        /// </summary>
        /// <returns>current View</returns>

        public ActionResult End()
        {
            return View();
        }
    }
}
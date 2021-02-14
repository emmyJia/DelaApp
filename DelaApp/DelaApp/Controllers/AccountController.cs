using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DelaApp.Models;
using DelaApp.Settings;
using DelaApp.ViewModels;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Logging;
using System.Data.Entity;
using DelaApp.Entity;

namespace DelaApp.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            if(Service.Account.SearchAccount(avm.Account.Username, avm.Account.Password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
    }
}
using FinalTUFOD.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FinalTUFOD.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminPage ad)
        { // şifre ve kullanıcı adı doğru ise admin paneline yönlendiren fonksiyon
            var info = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.username, false); 
                Session["username"] = info.username.ToString();
                return RedirectToAction("Index", "Admin"); // doğru girilince admin paneline yönlendirilir
            } // yanlışsa login panelindee kalmaya devam eder
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        { // çıkış yapma işlemi
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login"); // login paneline yönlendirir.
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MvcWeb.Controllers
{

    public class AdminController : Controller
    {
        Business.users us = new Business.users();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userid, string userpwrd)
        {
            bool b = us.Login(userid, userpwrd);
            if (b)
            {
                if (us.UserType == "admin")
                {
                    HttpContext.Session.SetString("UserName", us.UserName);
                    HttpContext.Session.SetString("UserId", userid);
                    return RedirectToAction("Index");
                }
                else {
                    @ViewBag.Error = "Error Role！";
                    return View();

                    
                }
            }
            else
            {
                @ViewBag.Error = us.ErrMsg;
                return View();
             
            }
        }

        public ActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserId");
            return View();
        }
    }
}

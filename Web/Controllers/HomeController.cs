using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace MvcWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Business.users us = new Business.users();
        Business.movie movie = new Business.movie();
        Business.comment comment = new Business.comment();
        Business.blacklist blacklist = new Business.blacklist();

        public ActionResult Index()
        {
            ViewBag.UserId = HttpContext.Session.GetString("UserId");
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.movielist = Business.ConvertHelper<MvcModel.movieData>.ConvertToList(movie.Top("9"));
            return View();
        }

        public ActionResult Login(string nologin)
        {
            if (nologin == "0")
            {
                HttpContext.Session.Clear();
                ViewBag.UserId = null;
                ViewBag.UserName = null;
                            return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userid, string userpwrd)
        {
            bool b = us.Login(userid, userpwrd);
            if (b)
            {
                HttpContext.Session.SetString("UserName", us.UserName);
                HttpContext.Session.SetString("UserId", userid);
                return RedirectToAction("Index");
            }
            else
            {
                //Response.Write("<script>alert('incorrect Username or password!');location.href='/Users/Login'</script>");
                @ViewBag.Error = us.ErrMsg;
                return View();
            }
        }

        public ActionResult Regsis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Regsis(string userid, string userpwrd, string username)
        {
            MvcModel.usersData ud = new MvcModel.usersData();
            ud.userid = userid;
            ud.userpwrd = userpwrd;
            ud.username = username;
            ud.usertype = "User";
            bool b = us.Insert(ud);
            if (b)
            {
                @ViewBag.Error = "Registration success~！";
                return View();
            }
            else
            {
                //Response.Write("<script>alert('incorrect Username or password!');location.href='/Users/Login'</script>");
                @ViewBag.Error = "Registration failed~！";
                return View();
            }
        }

        public ActionResult MovieList(string keyword, string mtype, string mcc, string mprice)
        {
            string casestr = "";
            if (!string.IsNullOrEmpty(keyword))
            {
                casestr += string.Format(" and mname like '%{0}%'", keyword);
            }
            if (mtype != "All" && !string.IsNullOrEmpty(mtype))
            {
                casestr += string.Format(" and mtype = '{0}'", mtype);
            }
            if (mcc != "All" && !string.IsNullOrEmpty(mtype))
            {
                casestr += string.Format(" and mcc = '{0}'", mcc);
            }
            if (mprice != "All" && !string.IsNullOrEmpty(mprice))
            {
                casestr += string.Format(" and mprice = '{0}'", mprice);
            }
            ViewBag.movielist = Business.ConvertHelper<MvcModel.movieData>.ConvertToList(movie.Get(casestr));
            return View();
        }

        public ActionResult Movie(string Id)
        {
            MvcModel.movieData moviedata = new MvcModel.movieData();
            if (Id == null)
            {

            }
            else
            {
                moviedata = movie.SelectData(string.Format(" and id = {0}", Id));

            }
            string casestr = string.Format(" and moduel ='Scoring' and mid ='{0}'", Id);
            ViewBag.commentlist = Business.ConvertHelper<MvcModel.commentData>.ConvertToList(comment.Get(casestr));
            return View(moviedata);
        }

        [HttpPost]
        public ActionResult Movie(string Id, string score, string thecon)
        {
            //moduel,mid,userid,thedate,thescore,thecon
            MvcModel.commentData cd = new MvcModel.commentData();
            if (HttpContext.Session.GetString("UserId") == null)
            {
                HttpContext.Response.WriteAsync("<script>alert('Pls login first!');location.href='/Home/Login'</script>");
                return null;
            }
            else
            {
                bool b = blacklist.Login(thecon);
                if (b)
                {
                    @ViewBag.Error = "Contains illegal words！";
                }
                else
                {
                    cd.moduel = "Scoring";
                    cd.mid = Id;
                    cd.userid = HttpContext.Session.GetString("UserId");
                    
                    cd.thedate = System.DateTime.Now.ToString();
                    cd.thescore = score;
                    cd.thecon = thecon;
                    comment.Insert(cd);
                }

                MvcModel.movieData moviedata = movie.SelectData(string.Format(" and id = {0}", Id));
                string casestr = string.Format(" and moduel ='Scoring' and mid ='{0}'", Id);
                ViewBag.commentlist = Business.ConvertHelper<MvcModel.commentData>.ConvertToList(comment.Get(casestr));
                return View(moviedata);
            }

        }


    }
}

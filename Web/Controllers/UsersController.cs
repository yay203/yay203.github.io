using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace Web.Controllers
{
    public class UsersController : Controller
    {
        Business.users us = new Business.users();

        //display data
        public IActionResult UsersList()
        {
            //return View(us.Get(""));
            return View(Business.Factory.GetGetTable("Users").SelectAll());
        }

        //Delete the column data according to the ID
        public IActionResult UsersDelete(string id)
        {
            us.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Users/UsersList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult UsersEdit(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                MvcModel.usersData userdata = us.SelectData(string.Format(" and id = {0}", id));
                return View(userdata);
            }
        }
        public IActionResult UpdatePassWord()
        {
            return View();
        }


        [HttpPost]
        public IActionResult UpdatePassWord(string password1, string password2)
        {
            if (password1 != password2)
            {
                @ViewBag.Error = "The password does not match！";
            }
            else if (password1 == "")
            {
                @ViewBag.Error = "Password is not allowed to be empty！";
            }
            else
            {
                us.Update(HttpContext.Session.GetString("UserId"), password1);
                @ViewBag.Error = "Update Succeeded！";
            }
            return View();
        }

        //Add or modify the column data

        [HttpPost]
        public IActionResult UsersEdit(MvcModel.usersData ud)
        {
            if (ud.Id == null)
            {
                us.Insert(ud);
                HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/Users/UsersList'</script>");
            }
            else
            {
                us.Modify(ud);
                HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/Users/UsersList'</script>");
            }
            return View(ud);
        }


    }
}

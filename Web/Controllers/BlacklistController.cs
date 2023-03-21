using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
namespace MvcWeb.Controllers
{
    public class BlacklistController : Controller
    {
        Business.blacklist blacklist = new Business.blacklist();

        //display data
        public IActionResult BlacklistList()
        {
            return View(blacklist.Get(""));
        }

        //Delete the column data according to the ID
        public IActionResult BlacklistDelete(string id)
        {
            blacklist.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Blacklist/BlacklistList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult BlacklistEdit(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                MvcModel.blacklistData blacklistdata = blacklist.SelectData(string.Format(" and id = {0}", id));
                return View(blacklistdata);
            }
        }

        //Add or modify the column data

        [HttpPost]
        public IActionResult BlacklistEdit(MvcModel.blacklistData blacklistdata)
        {
            if (ModelState.IsValid)
            {
                if (blacklistdata.Id == 0)
                {
                    blacklist.Insert(blacklistdata);
                    HttpContext.Response.WriteAsync("<script>alert('Insert Succeeded!');location.href='/blacklist/blacklistList'</script>");
                }
                else
                {
                    blacklist.Modify(blacklistdata);
                    HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/blacklist/blacklistList'</script>");
                }

                return null;
            }
            return View(blacklistdata);
        }

    }
}

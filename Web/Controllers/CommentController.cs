using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace MvcWeb.Controllers
{
    public class CommentController : Controller
    {
        Business.comment comment = new Business.comment();

        //display data
        public IActionResult CommentList()
        {
            return View(comment.Get(""));
        }

        //Delete the column data according to the ID
        public IActionResult CommentDelete(string id)
        {
            comment.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Comment/CommentList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult CommentEdit(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                MvcModel.commentData commentdata = comment.SelectData(string.Format(" and id = {0}", id));
                return View(commentdata);
            }
        }

        //Add or modify the column data
        [HttpPost]
        public IActionResult CommentEdit(MvcModel.commentData commentdata)
        {
            if (ModelState.IsValid)
            {
                if (commentdata.Id == 0)
                {
                    comment.Insert(commentdata);
                    HttpContext.Response.WriteAsync("<script>alert('Insert Succeeded!');location.href='/comment/commentList'</script>");
                }
                else
                {
                    comment.Modify(commentdata);
                    HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/comment/commentList'</script>");
                }

                return null;
            }
            return View(commentdata);
        }

        //Display all data - foreground
        public IActionResult HomeCommentList()
        {
            return View(comment.Get(""));
        }

        //Delete the column data according to the ID
        public IActionResult HomeCommentDelete(string id)
        {
            comment.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Comment/HomeCommentList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult HomeCommentEdit(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                MvcModel.commentData commentdata = comment.SelectData(string.Format(" and id = {0}", id));
                return View(commentdata);
            }
        }

        //Add or modify the column data
        [HttpPost]
        public IActionResult HomeCommentEdit(MvcModel.commentData commentdata)
        {
            if (ModelState.IsValid)
            {
                if (commentdata.Id == null)
                {
                    comment.Insert(commentdata);
                    HttpContext.Response.WriteAsync("<script>alert('Insert Succeeded!');location.href='/Comment/HomeCommentList'</script>");
                }
                else
                {
                    comment.Modify(commentdata);
                    HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/Comment/HomeCommentList'</script>");
                }

                return null;
            }
            return View(commentdata);
        }

    }
}

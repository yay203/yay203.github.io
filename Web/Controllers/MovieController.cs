using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MvcWeb.Controllers
{
    public class MovieController : Controller
    {
        Business.movie movie = new Business.movie();

        //display data
        public IActionResult MovieList()
        {
            return View(movie.Get(""));
        }

        //Delete the column data according to the ID
        public IActionResult MovieDelete(string id)
        {
            movie.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Movie/MovieList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult MovieEdit(string id)
        {
            MvcModel.movieData moviedata = new MvcModel.movieData();
            if (id == null)
            {

            }
            else
            {
                moviedata = movie.SelectData(string.Format(" and id = {0}", id));

            }
            return View(moviedata);
        }

        //Add or modify the column data

        [HttpPost]
        public ActionResult MovieEdit(MvcModel.movieData moviedata, [FromServices]IHostingEnvironment env, IFormFile uploadfile)
        {
            if (uploadfile != null && !string.IsNullOrEmpty(uploadfile.FileName))
            {
                string newName = DateTime.Now.ToString("MMddHHmmss") + ".jpg";
                var fileName = Path.Combine("upload", newName);
                using (var stream = new FileStream(Path.Combine(env.WebRootPath, fileName), FileMode.CreateNew))
                {
                    uploadfile.CopyTo(stream);
                }
                moviedata.mpic = newName;
            }
 

            if (moviedata.Id == 0)
            {
                movie.Insert(moviedata);
                HttpContext.Response.WriteAsync("<script>alert('Insert Succeeded!');location.href='/movie/movieList'</script>");
            }
            else
            {
                movie.Modify(moviedata);
                HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/movie/movieList'</script>");
            }
            return View(moviedata);
        }

        //Display data
        public IActionResult HomeMovieList()
        {
            return View(movie.Get(""));
        }

        //Delete the column data according to the ID
        public IActionResult HomeMovieDelete(string id)
        {
            movie.Delete(id);
            HttpContext.Response.WriteAsync("<script>alert('Delete Succeeded!');location.href='/Movie/HomeMovieList'</script>");
            return null;
        }

        //Export the column data according to the ID
        public IActionResult HomeMovieEdit(string id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                MvcModel.movieData moviedata = movie.SelectData(string.Format(" and id = {0}", id));
                return View(moviedata);
            }
        }

        //Add or modify the column data
        [HttpPost]
        public IActionResult HomeMovieEdit(MvcModel.movieData moviedata)
        {
            if (ModelState.IsValid)
            {
                if (moviedata.Id == null)
                {
                    movie.Insert(moviedata);
                    HttpContext.Response.WriteAsync("<script>alert('Insert Succeeded!');location.href='/Movie/HomeMovieList'</script>");
                }
                else
                {
                    movie.Modify(moviedata);
                    HttpContext.Response.WriteAsync("<script>alert('Update Succeeded!');location.href='/Movie/HomeMovieList'</script>");
                }

                return null;
            }
            return View(moviedata);
        }

    }
}

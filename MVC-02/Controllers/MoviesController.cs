using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace MVC_02.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id,string name , Employee employee)
        {
            return Content($"Movie is id :{id}");
        }
        //public string Index()
        //{
        //    return "Hello From The Index";
        //}
        //public ContentResult Index()
        //{
        //    ContentResult result = new ContentResult() { Content = "Hello From The Index" };
        //    return result;
        //    //result.ContentType= "text/html";
        //    //result.ContentType = "object/pdf";
        //}

        public IActionResult Index()
        {
           
            return Content("Hello From The Index");
            //result.ContentType= "text/html";
            //result.ContentType = "object/pdf";
        }
        public IActionResult Redirect()
        {
            //return RedirectToAction(nameof(Index));
            return RedirectToRoute(new { Controller = "Movies", action = "Index" });
        }
    }
}

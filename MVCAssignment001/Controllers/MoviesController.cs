using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCAssignment001.Controllers
{
    public class MoviesController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return Content("Hello");
        }

        #region Action Return types
        //1-Content result
        //public ContentResult Index()
        //{
        //    ContentResult result = new();
        //    result.Content = "Test";
        //    result.ContentType = "object/pdf";//or Text/html open html page 
        //    return result;
        //}

        //2- redirectResult => redirect to another page/action
        #endregion


        //public IActionResult GetMovie(int id)
        //{
        //    return Content($"Movie with Id:{id}");

        //}
        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Movie with Id:{movie.Id} :: with Name:{movie.Name}");

        }


    }
}

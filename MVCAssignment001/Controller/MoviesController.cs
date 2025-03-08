using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCAssignment001.Controller
{
    public class MoviesController : ControllerBase
    {
        //public string Index()
        //{
        //    return("Hello");
        //}

        #region Action Return types
        //1-Content result
        public ContentResult Index()
        {
            ContentResult result = new();
            result.Content = "Test";
            result.ContentType = "object/pdf";//or Text/html open html page 
            return result;
        }
        #endregion


        //public void GetMovie()
        //{

        //}

    }
}

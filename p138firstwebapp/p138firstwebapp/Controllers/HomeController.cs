using Microsoft.AspNetCore.Mvc;

namespace p138firstwebapp.Controllers
{
    public class HomeController : Controller
    {

        public FileResult Index()
        {

        }


        //public ViewResult Index()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName= "test";
        //    return viewResult;

        //}



        //public ContentResult Index()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "p138 salam Content";
        //    result.ContentType = "text";
        //    result.StatusCode= 600;
        //    return result;


        //}
        //public JsonResult Index()
        //{
        //    JsonResult jsonResult = new JsonResult("Salam");
        //    jsonResult.StatusCode = 200;

        //    return jsonResult;


        //}
    }
}

using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;

namespace DevCard_mvc.Controllers
{
    public class test : Controller
    {
        // public IActionResult Index()
        // {
        //     return PartialView("Footer");
        // }

        // public PartialViewResult Index()
        // {
        //     return PartialView("Footer");
        // }

        //
        // public ContentResult Index()
        // {
        //     // return Content("<h1>Hello MR.Vosooghi</h1>", "text/html");
        //     return Content("<h1>Hello MR.Vosooghi</h1>");
        //
        // }

        // public IActionResult Index()
        // {
        //     // return Content("<h1>Hello MR.Vosooghi</h1>", "text/html");
        //     return Content("<h1>Hello MR.Vosooghi</h1>");
        //
        // }


        // public EmptyResult Index()
        // {
        //     // return new EmptyResult();
        //     // return null;
        //
        // 
        // public FileResult Index()
        // {
        //     // return File("~/test.txt","text/html");
        //
        //     var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //     const string filename = "testfile.txt";
        //     return File(fileByte, MediaTypeNames.Text.Plain, filename);
        //
        //
        // }

        // public JsonResult Index()
        // {
        //     return Json(new
        //     {
        //         id=1,
        //         name="reza",
        //         job="Programmer",
        //         site="jorin.com"
        //
        //     });
        // public JavascriptResult Index()
        // {
        //     return new JavascriptResult("alert('hello')");
        // }

        // public RedirectResult Index()
        // {
        //     return Redirect("https://www.google.com");
        //
        // }

        // public RedirectToActionResult Index()
        // {
        //     return RedirectToAction("Contact", "Home");
        //
        // }


        public IActionResult Index()
        {
            // return new OkResult();
            // return new NotFoundResult();
            // return new BadRequestResult();
            return new StatusCodeResult(369);
        }
        
    }

        // public class JavascriptResult : ContentResult
        // {
        //     public JavascriptResult(string dataa)
        //     {
        //         Content = dataa;
        //         ContentType = "Application/javascript";
        //
        //     }
        // }



    }

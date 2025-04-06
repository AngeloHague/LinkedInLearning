// Created with: dotnet new mvccontroller -n EngineeringController -o Controllers --namespace mvc_app.Controllers
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;

namespace mvc_app.Controllers
{
    public class EngineeringController : Controller
    {
        // GET: EngineeringController
        public ActionResult Index()
        {
            return View();
        }

        // Notice that these return ActionResults, instead of IActionResults as in HomeController
        // This is an abstract class that is implemented by the IActionResult interface 
        public ActionResult CurrentProjects()
        {
            // Finish this in the next lesson
            var engineeringDepartment = new EngineeringDepartment();
            // return View();
        }


    }
}

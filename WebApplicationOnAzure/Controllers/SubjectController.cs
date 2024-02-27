using Microsoft.AspNetCore.Mvc;
using WebApplicationOnAzure.Models;
using System.Xml.Linq;

namespace WebApplicationOnAzure.Controllers
{
    public class SubjectController : Controller
    {
        List<Subject> subject = new List<Subject>()
        { 

            new Subject { SubId = 1,SubName = "Biology" },
            new Subject { SubId = 2,SubName = "Physics" },
            new Subject { SubId = 3, SubName = "Mathematics" },
       
        };
        public IActionResult Index()
        {
            return View(subject);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }
        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subject.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}


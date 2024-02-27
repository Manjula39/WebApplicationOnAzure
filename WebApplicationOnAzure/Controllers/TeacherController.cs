using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplicationOnAzure.Models;

namespace WebApplicationOnAzure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { TId = 1, TName ="Mr.Sathish", TeachingSub ="Biology"},
            new Teacher { TId = 2, TName ="Mr.Kiran", TeachingSub ="Physics"},
            new Teacher { TId = 3, TName ="Mrs.Savitha", TeachingSub="Mathematics"},
            new Teacher { TId = 4, TName ="Mr.Gangadhar", TeachingSub="Chemistry"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }
        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
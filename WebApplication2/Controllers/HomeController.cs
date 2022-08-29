using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.name = "Rafet";
            //ViewData["Surname"] = "Memmedov";
            //TempData["FullName"] = "Raf@Mammadoff";

            Student studen1 = new Student("Rafet","Memmedov",23);
            Student studen2 = new Student("Xeyal","Memmedov",23);
            Student studen3 = new Student("Eli","Memmedov",23);

            List<Student> students = new List<Student>();
            students.Add(studen1);
            students.Add(studen2);
            students.Add(studen3);

            return View(students);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

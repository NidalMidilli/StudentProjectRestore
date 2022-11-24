using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UISchool.Models;
using EntityLayer;

namespace UISchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        private readonly IStudentService studentService;
        Student st;
       
        public HomeController(ILogger<HomeController> logger,IStudentService studentService)
        {
            _logger = logger;
            this.studentService = studentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAllStudents()
        {
            var result = studentService.ListAllStudents();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

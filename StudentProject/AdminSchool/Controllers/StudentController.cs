using AdminSchool.Models;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminSchool.Controllers
{
    public class StudentController : Controller
    {
        private readonly Context c = new Context();
        private readonly IStudentService studentService;
        Student st;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

   
        public IActionResult Index()
        {
            var result = studentService.ListAllStudents();
            return View(result);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Student student)
        {
            StudentValidator studentValidator = new StudentValidator();
            ValidationResult results = studentValidator.Validate(student);
            if (results.IsValid)
            {
                studentService.AddStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]

        public IActionResult Update(int id)
        {
            var result = c.Students.FirstOrDefault(x => x.studentId == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            StudentValidator studentValidator = new StudentValidator();
            ValidationResult results = studentValidator.Validate(student);
            if (results.IsValid)
            {
                studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = c.Students.FirstOrDefault(x => x.studentId == id);
            studentService.DeleteStudent(result);
            return RedirectToAction("Index");
        }
   

    }
    }


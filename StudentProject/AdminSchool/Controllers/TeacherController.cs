using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace AdminSchool.Controllers
{
    public class TeacherController : Controller
    {
        private readonly Context c = new Context();
        private readonly ITeacherService teacherservice;
        Teacher teach;



        public TeacherController(ITeacherService teacherservice)
        {
            this.teacherservice = teacherservice;
        }
        public IActionResult Index()
        {

            var result = teacherservice.ListAllTeachers();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Add(Teacher teacher)
        {
            TeacherValidator teacherValidator = new TeacherValidator();
            ValidationResult results = teacherValidator.Validate(teacher);
            if (results.IsValid)
            {
                teacherservice.AddTeacher(teacher);
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
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Teacher teacher)
        {
            TeacherValidator teacherValidator = new TeacherValidator();
            ValidationResult results = teacherValidator.Validate(teacher);
            if (results.IsValid)
            {
                teacherservice.UpdateTeacher(teacher);
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
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Teacher teacher)
        {
            teacherservice.DeleteTeacher(teacher);
            return RedirectToAction("Index");
        }

    }
}

using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.studentName).NotEmpty().WithMessage("Öğrenci ismi boş geçilemez")
                                        .MinimumLength(3).WithMessage("Öğrenci Adı 3 harfden fazla olmalı")
                                        .MaximumLength(30).WithMessage("Öğrenci Adı 30 harfden fazla olamaz");


        }
    }
}

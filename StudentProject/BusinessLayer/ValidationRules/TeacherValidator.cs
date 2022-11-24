using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeacherValidator:AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.teacherName).NotEmpty().WithMessage("Öğretmen ismi boş geçilemez")
                                        .MinimumLength(3).WithMessage("Öğretmen Adı 3 harfden fazla olmalı")
                                        .MaximumLength(30).WithMessage("Öğretmen Adı 30 harfden fazla olamaz");
        }
    }
}

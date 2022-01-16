using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using sms.Models;

namespace ERPSystem.Validators
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty()
                .WithMessage("Поле \"Ім'я\" обов'язкове");
            RuleFor(m => m.LastName).NotEmpty()
                .WithMessage("Поле \"Прізвище\" обов'язкове");
            RuleFor(m => m.Patronymic).NotEmpty()
                .WithMessage("Поле \"По батькові\" обов'язкове");
        }
    }
}

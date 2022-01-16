﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using sms.Models;

namespace ERPSystem.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(m => m.DateOfBirth)
                .LessThan(DateTime.Now.AddYears(-5))
                .WithMessage("Прийом до школи з п'ятирічного віку");

            RuleFor(m => m.DateOfBirth)
                .GreaterThan(DateTime.Now.AddYears(-19))
                .WithMessage("Прийом до школи до 18 років включно");
            RuleFor(m => m.FirstName).NotEmpty()
                .WithMessage("Поле \"Ім'я\" обов'язкове");
            RuleFor(m => m.LastName).NotEmpty()
                .WithMessage("Поле \"Прізвище\" обов'язкове");
            RuleFor(m => m.Patronymic).NotEmpty()
                .WithMessage("Поле \"По батькові\" обов'язкове");
            RuleFor(m => m.DateOfBirth).NotEmpty()
                .WithMessage("Поле \"Дата нар.\" обов'язкове");
        }
    }
}

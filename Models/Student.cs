using sms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sms
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Прізвище не може бути довше за 50 символів.")]
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Ім'я не може бути довше за 50 символів.")]
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "По батькові не може бути довше за 50 символів.")]
        [Display(Name = "По батькові")]
        public string Patronymic { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата нар.")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(50)]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [StringLength(20)]
        [Display(Name = "Стать")]
        public string Gender { get; set; }

        [StringLength(70, ErrorMessage = "Ім'я файлу занадто довге.")]
        [Display(Name = "Фото")]
        public string ProfilePicture { get; set; }

        [Display(Name = "ПІБ учня")]
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }
        public string ShortName
        {
            get
            {
                if(!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(Patronymic))
                return LastName + " " + FirstName[0] + "." + Patronymic[0] + ".";
                return "";
            }
        }
        [Display(Name = "Вік")]
        public int Age
        {
            get
            {
                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - DateOfBirth.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                
                return age;
            }
        }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}

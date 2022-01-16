using sms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле \"Прізвище\" обов'язкове")]
        [StringLength(50, ErrorMessage = "Прізвище не може бути довше за 50 символів.")]
        [RegularExpression(@"^[А-ЯІЇЄ']+[а-яА-Яіїє'-]*$")]
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле \"Ім'я\" обов'язкове")]
        [StringLength(50, ErrorMessage = "Ім'я не може бути довше за 50 символів.")]
        [RegularExpression(@"^[А-ЯІЇЄ']+[а-яА-Яіїє'-]*$")]
        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле \"По батькові\" обов'язкове")]
        [StringLength(50, ErrorMessage = "По батькові не може бути довше за 50 символів.")]
        [RegularExpression(@"^[А-ЯІЇЄ']+[а-яА-Яіїє'-]*$")]
        [Display(Name = "По батькові")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Поле \"Дата нар.\" обов'язкове")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата нар.")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(50)]
        [RegularExpression(@"^[а-яА-Я0-9A-Za-zІЇЄіїє""'\s-.,]*$")]
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
        [Display(Name = "ПІБ учня")]
        public string ShortName
        {
            get
            {
                StringBuilder sb = new StringBuilder("");
                if (!string.IsNullOrEmpty(LastName)) sb.Append(LastName + " ");
                if (!string.IsNullOrEmpty(LastName)) sb.Append(FirstName[0] + ".");
                if (!string.IsNullOrEmpty(Patronymic)) sb.Append(Patronymic[0] + ".");
                return sb.ToString();

                //if (!string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(Patronymic))
                //return LastName + " " + FirstName[0] + "." + Patronymic[0] + ".";
                //return "";
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
        public ICollection<Book> Books { get; set; }
    }
}

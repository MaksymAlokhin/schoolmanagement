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
        [Display(Name = "Дата народження")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(50)]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Display(Name = "ПІБ")]
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}

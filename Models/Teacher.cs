using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Teacher
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

        [Required]
        [StringLength(50, ErrorMessage = "По батькові не може бути довше за 50 символів.")]
        [Display(Name = "По батькові")]
        public string Patronymic { get; set; }

        [Display(Name = "ПІБ вчителя")]
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }
        public ICollection<Subject> Subjects { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        [Display(Name = "Завдання")]
        public string Post { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата")]
        public DateTime DateOfPost { get; set; } = DateTime.Now;
        public int GradeId { get; set; }
        [Display(Name = "Клас")]
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        [Display(Name = "Предмет")]
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        [Display(Name = "Вчитель")]
        public Teacher Teacher { get; set; }

    }
}

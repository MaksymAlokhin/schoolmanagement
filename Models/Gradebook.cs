using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Gradebook
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата уроку")]
        public DateTime LessonDate { get; set; }

        [StringLength(20, ErrorMessage = "Оцінка не може бути довше за 20 символів.")]
        [Display(Name = "Оцінка")]
        public string Mark { get; set; }

        [Display(Name = "Учень")]
        public int StudentId { get; set; }
        [Display(Name = "Учень")]
        public Student Student { get; set; }
        [Display(Name = "Предмет")]
        public int SubjectId { get; set; }
        [Display(Name = "Предмет")]
        public Subject Subject { get; set; }
        [Display(Name = "Вчитель")]
        public int TeacherId { get; set; }
        [Display(Name = "Вчитель")]
        public Teacher Teacher { get; set; }
    }
}

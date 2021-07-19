using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public enum day
    {
        Пн,
        Вт,
        Ср,
        Чт,
        Пт
    }
    public class Lesson
    {
        public int Id { get; set; }

        //[Required]
        //[Display(Name = "День")]
        //[StringLength(50)]
        //public string Day { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        [Required]
        [Display(Name = "День")]
        public day day { get; set; }

        [Required]
        [Display(Name = "№ уроку")]
        public int Slot { get; set; }

        [Display(Name = "Кабінет")]
        [StringLength(50)]
        public string Room { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

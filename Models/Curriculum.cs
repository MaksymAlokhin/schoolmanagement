using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        [Display(Name = "Ур./тижд.")]
        public int Quantity { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}

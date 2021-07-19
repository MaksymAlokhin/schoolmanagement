using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [Display(Name = "Клас")]
        public int Number { get; set; }
        [Display(Name = "Буква")]
        public string Letter { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}

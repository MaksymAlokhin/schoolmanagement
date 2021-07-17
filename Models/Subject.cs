using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Subject
    {
        public int ID { get; set; }
        [Display(Name = "Предмет")]
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}

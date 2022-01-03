using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Предмет")]
        public string Name { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}

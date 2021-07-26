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
        
        [Display(Name = "Кабінет")]
        [StringLength(50)]
        public string Room { get; set; }
        
        [Display(Name = "Клас")]
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(Letter))
                {
                    return Number.ToString();
                }
                else
                {
                    return Number + "-" + Letter;
                }
            }
        }

        public ICollection<Student> Students { get; set; }
    }
}

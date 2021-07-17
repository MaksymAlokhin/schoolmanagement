using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Lesson
    {
        public int ID { get; set; }
        public string Day { get; set; }
        public int Slot { get; set; }
        public Grade Grade { get; set; }
        public Subject Subject { get; set; }
        public string Teacher { get; set; }
        public string Room { get; set; }
    }
}

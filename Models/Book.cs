using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Автор")]
        [StringLength(50, ErrorMessage = "Список авторів не може бути довше за 50 символів.")]
        public string Author { get; set; }
        [Display(Name = "Назва")]
        [StringLength(50, ErrorMessage = "Назва книги не може бути довше за 50 символів.")]
        public string Name { get; set; }
        [Display(Name = "Видавництво")]
        [StringLength(50, ErrorMessage = "Назва видавництва не може бути довше за 50 символів.")]
        public string PublishingHouse { get; set; }
        [Display(Name = "Рік вид.")]
        public int Year { get; set; }
        [Display(Name = "Клас")]
        public int? Grade { get; set; }

        [Display(Name = "К-ть")]
        public int Qty { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        //public int TotalQty
        //{
        //    get
        //    {
        //        return Qty + Students.Count + Teachers.Count;
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле \"Найменування\" обов'язкове")]
        [Display(Name = "Найменування")]
        public string Name { get; set; }

        [Display(Name = "Інв. №")]
        public int InventoryNumber { get; set; }

        [Display(Name = "К-ть")]
        public int Quantity { get; set; }

        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Display(Name = "Оприбутк.")] //Дата оприбуткування
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InventoryDate { get; set; }

        [Display(Name = "Списано")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DecommissionDate { get; set; }
    }
}

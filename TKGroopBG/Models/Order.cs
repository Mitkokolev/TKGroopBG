using System;
using System.ComponentModel.DataAnnotations;

namespace TKGroopBG.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името е задължително")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Продуктът е задължителен")]
        public string Product { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}


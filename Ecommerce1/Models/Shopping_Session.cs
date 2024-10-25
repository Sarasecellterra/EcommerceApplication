using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Models
{
    public class Shopping_Session

    {
        [Key]
        public int Id_Shop_Session{get; set;}
        public int Id_user { get; set; }
        [Required]

        public decimal Total_price { get; set;}  
        public string Created { get; set; }
        public string Modified { get; set; }

        [ForeignKey("Id_user")]
        public User Users { get; set; }

    }
}

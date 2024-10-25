using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Models
{
    public class Order_Details
    {
        [Key]
        public int Id_details { get; set; }


        public int Id_User { get; set; }

        public int Id_Order { get; set; }

        
        

        [Required]
        public string Created { get; set; }

        public string Modified { get; set; }

        
        [ForeignKey("Id_Order")]
        public Order Orders { get; set; }

        
        [ForeignKey("Id_User")]
        public User Users { get; set; }

        
    }
}

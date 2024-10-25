using System.ComponentModel.DataAnnotations;

namespace Ecommerce1.Models
{
    public class User
    {
        [Key]
        public int Id_User { get; set; }
        [Required]
        public string Email { get; set; }
        public required string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone_number { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }


        public ICollection<Shopping_Session> Shopping_Sessions { get; set; }//Linked Shopping_Session
        public ICollection<Order_Details> Order_Detail { get; set; }//Linked Order_Details
        public virtual ICollection<AppUser> AppUsers { get; set; }

    }
}

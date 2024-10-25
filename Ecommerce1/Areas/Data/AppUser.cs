using Ecommerce1.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class AppUser : IdentityUser
{
    [Key]
    public int Id_AppUser { get; set; }

    public int Id_User { get; set; }

    public  string Email
    {get;set;}


        public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Created { get; set; }
    public string Modified { get; set; }

    [ForeignKey("Id_User")]
    public virtual User User { get; set; }

    public void SetPassword(string password, IPasswordHasher<AppUser> passwordHasher)
    {
        PasswordHash = passwordHasher.HashPassword(this, password);
    }

    internal void SynchronizeUser(User existingUser)
    {
        throw new NotImplementedException();
    }
}

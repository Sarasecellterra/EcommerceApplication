using Ecommerce1.Data;
using Ecommerce1.Models;
using Microsoft.AspNetCore.Identity;

namespace  Ecommerce1.Services;

public class AppUserService
{
    private readonly ApplicationDbContext _context;
    private readonly IPasswordHasher<AppUser> _passwordHasher;

    public AppUserService(ApplicationDbContext context, IPasswordHasher<AppUser> passwordHasher)
    {
        _context = context;
        _passwordHasher = passwordHasher;
    }

    public async Task CreateOrUpdateAppUserAsync(AppUser appUser)
    {
        // Check if the AppUser already exists
        var existingUser = await _context.Users.FindAsync(appUser.Id_User);

        if (existingUser != null)
        {
            // Update existing AppUser
            existingUser.Email = appUser.Email;
            existingUser.FirstName = appUser.FirstName;
            existingUser.LastName = appUser.LastName;
            existingUser.Modified = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            // Call SynchronizeUser to update User data
            appUser.SynchronizeUser(existingUser);

            _context.Users.Update(existingUser); // Update user record
        }
        else
        {
            // Create a new AppUser
            appUser.SetPassword(appUser.PasswordHash, _passwordHasher); // Hash the password

            // Create new User instance
            var newUser = new User
            {
                Email = appUser.Email,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                PasswordHash = appUser.PasswordHash,
                Created = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                Modified = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")
            };

            // Set other properties as needed
            appUser.User = newUser; // Link the User to AppUser

            // Add to the context
            await _context.Users.AddAsync(newUser);
        }

        // Save changes to the database
        await _context.SaveChangesAsync();
    }
}

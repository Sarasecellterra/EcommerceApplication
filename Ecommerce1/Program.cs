using Ecommerce1.Data; //  DB context
using Ecommerce1.Models; // Your AppUser model
using Ecommerce1.Services; // AppUserService
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Register ApplicationDbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add the developer page exception filter for database operations
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Configure Identity with AppUser
builder.Services.AddDefaultIdentity<AppUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true; // Requires email confirmation
})
.AddEntityFrameworkStores<ApplicationDbContext>(); // Link Identity with the DB context

// Register the AppUserService
builder.Services.AddScoped<AppUserService>(); // Add your AppUserService to the DI container

// Add MVC and Razor Pages support
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint(); // Enable migration endpoint for development
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Custom error handling page
    app.UseHsts(); // Use HTTP Strict Transport Security
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files

app.UseRouting(); // Enable routing

app.UseAuthentication(); // Enable authentication middleware
app.UseAuthorization(); // Enable authorization middleware

// Define the default route for controllers
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Map Razor Pages
app.MapRazorPages();

// Run the application
app.Run();

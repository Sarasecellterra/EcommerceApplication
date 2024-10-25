using Ecommerce1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets for various entities
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shopping_Session> ShoppingSessions { get; set; }
        public DbSet<Cart_item> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Details> OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // AppUser DbSet
        public DbSet<AppUser> AppUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the one-to-one relationship between AppUser and User
            modelBuilder.Entity<AppUser>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.Id_User);

            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User { Id_User = 1, Email = "john.doe@gmail.com", PasswordHash = "gM}56fjg", FirstName = "John", LastName = "Doe", Address = "1234 Elm St, Springfield", Phone_number = "+1 555-123-4567", Created = "2023-10-01 10:30:00", Modified = "2023-10-10 12:45:00" },
                new User { Id_User = 2, Email = "jane.smith@protonmail.com", PasswordHash = ">3LUmc=RvyGRHW%g/-~z", FirstName = "Jane", LastName = "Smith", Address = "5678 Oak St, Greenfield", Phone_number = "+1 555-987-6543", Created = "2023-10-02 11:20:00", Modified = "2023-10-11 15:00:00" },
                new User { Id_User = 3, Email = "mark.williams@domain.com", PasswordHash = "x*D5-UV/89`&^_q,v-H7", FirstName = "Mark", LastName = "Williams", Address = "9101 Pine St, Brookfield", Phone_number = "+1 555-321-7654", Created = "2023-10-03 14:45:00", Modified = "2023-10-12 09:10:00" },
                new User { Id_User = 4, Email = "emma.jones@outlook.com", PasswordHash = "fCxwnchJs1w|-S}YA>-F", FirstName = "Emma", LastName = "Jones", Address = "2468 Maple St, Hilltown", Phone_number = "+1 555-654-3210", Created = "2023-10-04 09:50:00", Modified = "2023-10-11 16:30:00" },
                new User { Id_User = 5, Email = "robert.brown@yahoo.com", PasswordHash = "(y.<vQ3[8w*]KYgMs3ab", FirstName = "Robert", LastName = "Brown", Address = "1357 Birch St, Riverview", Phone_number = "+1 555-555-7890", Created = "2023-10-05 08:30:00", Modified = "2023-10-12 14:20:00" }
            );

            // Seed data for AppUser
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id_AppUser = 1, Id_User = 1, FirstName = "John", LastName = "Doe", PasswordHash = "Password1", Email = "john.doe@gmail.com", Created = "2023-10-01", Modified = "2023-10-10" },
                new AppUser { Id_AppUser = 2, Id_User = 2, FirstName = "Jane", LastName = "Smith", PasswordHash = "Password2", Email = "jane.smith@protonmail.com", Created = "2023-10-02", Modified = "2023-10-11" },
                new AppUser { Id_AppUser = 3, Id_User = 3, FirstName = "Mark", LastName = "Williams", PasswordHash = "Password3", Email = "mark.williams@domain.com", Created = "2023-10-03", Modified = "2023-10-12" },
                new AppUser { Id_AppUser = 4, Id_User = 4, FirstName = "Emma", LastName = "Jones", PasswordHash = "Password4", Email = "emma.jones@outlook.com", Created = "2023-10-04", Modified = "2023-10-11" },
                new AppUser { Id_AppUser = 5, Id_User = 5, FirstName = "Robert", LastName = "Brown", PasswordHash = "Password5", Email = "robert.brown@yahoo.com", Created = "2023-10-05", Modified = "2023-10-12" }
            );

            // Discounts
            modelBuilder.Entity<Discount>().HasData(
                new Discount { Id_discount = 1, Name = "Fruit Discount", Description = "10% off all fruits", Percent = 10, Created = "2023-10-01 10:30:00", Modified = "2023-10-01 10:30:00" },
                new Discount { Id_discount = 2, Name = "Dairy Discount", Description = "15% off on dairy products", Percent = 15, Created = "2023-10-02 10:30:00", Modified = "2023-10-02 10:30:00" },
                new Discount { Id_discount = 3, Name = "Bakery Discount", Description = "Buy 2 Get 1 Free on bakery items", Percent = 5, Created = "2023-10-03 10:30:00", Modified = "2023-10-03 10:30:00" },
                new Discount { Id_discount = 4, Name = "Meat Discount", Description = "Buy 3 Get 1 Free on meat products", Percent = 10, Created = "2023-10-03 10:30:00", Modified = "2023-10-03 10:30:00" }
            );

            // Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id_product = 1, Name = "Apple", Description = "Fresh Red Apple", Price = 0.99m, SKU = "FRU-APL-001", Category = "Fruits", Created = "2023-10-01 10:30:00", Modified = "2023-10-05 14:20:00", Id_discount = 1 },
                new Product { Id_product = 2, Name = "Banana", Description = "Exotic Bananas", Price = 1.20m, SKU = "FRU-BAN-002", Category = "Fruits", Created = "2023-10-02 09:15:00", Modified = "2023-10-06 12:40:00", Id_discount = 1 },
                new Product { Id_product = 3, Name = "Carrot", Description = "Fresh Carrots", Price = 0.50m, SKU = "VEG-CAR-003", Category = "Vegetables", Created = "2023-10-03 11:30:00", Modified = "2023-10-07 09:00:00", Id_discount = null },
                new Product { Id_product = 4, Name = "Lemon", Description = "Fresh Lemon", Price = 2.50m, SKU = "VEG-TOM-004", Category = "Vegetables", Created = "2023-10-04 14:45:00", Modified = "2023-10-08 16:20:00", Id_discount = null },
                new Product { Id_product = 5, Name = "Milk", Description = "Whole Milk, 1 Gallon", Price = 3.99m, SKU = "DAR-MIL-005", Category = "Dairy", Created = "2023-10-05 08:30:00", Modified = "2023-10-09 15:35:00", Id_discount = 2 },
                new Product { Id_product = 6, Name = "Eggs", Description = "Dozen Organic Eggs", Price = 2.99m, SKU = "DAR-EGG-006", Category = "Dairy", Created = "2023-10-06 12:00:00", Modified = "2023-10-10 18:00:00", Id_discount = 2 },
                new Product { Id_product = 7, Name = "Bread", Description = "Whole Wheat Bread Loaf", Price = 2.50m, SKU = "BAK-BRD-007", Category = "Bakery", Created = "2023-10-07 07:50:00", Modified = "2023-10-11 12:15:00", Id_discount = 3 },
                new Product { Id_product = 8, Name = "Chicken Breast", Description = "Skinless Boneless Chicken Breast, 1 lb", Price = 4.99m, SKU = "MEA-CHK-008", Category = "Meat", Created = "2023-10-08 09:30:00", Modified = "2023-10-12 11:45:00", Id_discount = 4 }
            );

            // Sessions
            modelBuilder.Entity<Shopping_Session>().HasData(
                new Shopping_Session { Id_Shop_Session = 1, Id_user = 1, Total_price = 5.00m, Created = "2023-10-12", Modified = "2023-10-12" },
                new Shopping_Session { Id_Shop_Session = 2, Id_user = 2, Total_price = 8.50m, Created = "2023-10-13", Modified = "2023-10-13" },
                new Shopping_Session { Id_Shop_Session = 3, Id_user = 3, Total_price = 3.99m, Created = "2023-10-14", Modified = "2023-10-14" }
            );

            // Cart
            modelBuilder.Entity<Cart_item>().HasData(
                new Cart_item { Id_cart = 1, Id_Shop_Session = 1, Id_product = 1, Quantity = 2, Created = "2023-10-12", Modified = "2023-10-12" },
                new Cart_item { Id_cart = 2, Id_Shop_Session = 2, Id_product = 2, Quantity = 3, Created = "2023-10-13", Modified = "2023-10-13" },
                new Cart_item { Id_cart = 3, Id_Shop_Session = 3, Id_product = 3, Quantity = 1, Created = "2023-10-14", Modified = "2023-10-14" }
            );

            // Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { Id_Order = 1, Id_product = 1, Created = "2023-10-12", Modified = "2023-10-12" },
                new Order { Id_Order = 2, Id_product = 2, Created = "2023-10-13", Modified = "2023-10-13" },
                new Order { Id_Order = 3, Id_product = 3, Created = "2023-10-14", Modified = "2023-10-14" }
            );

            // Order details
            modelBuilder.Entity<Order_Details>().HasData(
                new Order_Details { Id_details = 1, Id_User = 1, Id_Order = 1, Created = "2023-10-12", Modified = "2023-10-12" },
                new Order_Details { Id_details = 2, Id_User = 2, Id_Order = 2, Created = "2023-10-13", Modified = "2023-10-13" },
                new Order_Details { Id_details = 3, Id_User = 3, Id_Order = 3, Created = "2023-10-14", Modified = "2023-10-14" }
            );

            // Payments
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id_payments = 1, Id_Order = 1, Amount = 5.00m, Provider = "PayPal", Status = "Completed", Created = "2023-10-12", Modified = "2023-10-12" },
                new Payment { Id_payments = 2, Id_Order = 2, Amount = 8.50m, Provider = "Credit Card", Status = "Pending", Created = "2023-10-13", Modified = "2023-10-13" },
                new Payment { Id_payments = 3, Id_Order = 3, Amount = 3.99m, Provider = "Bank Transfer", Status = "Completed", Created = "2023-10-14", Modified = "2023-10-14" }
            );

    

        }
    }
}

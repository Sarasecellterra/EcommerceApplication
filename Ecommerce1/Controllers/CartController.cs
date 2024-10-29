using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

public class CartController : Controller
{
    private readonly string _connectionString;

    public CartController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<CartItemViewModel> cartItems = new List<CartItemViewModel>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            //Command to read from the database.
            SqlCommand command = new SqlCommand(
                @"SELECT c.Id_cart, c.Quantity, p.Name, p.Price 
                  FROM CartItems c 
                  JOIN Product p ON c.Id_product = p.Id_product", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cartItems.Add(new CartItemViewModel
                {
                    Id_cart = reader.GetInt32(0),
                    Quantity = reader.GetInt32(1),
                    ProductName = reader.GetString(2),
                    Price = reader.GetDecimal(3)
                });
            }
        }

        return View(cartItems);
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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

            // Join Cart_item and Product tables to get product names and other details
            SqlCommand command = new SqlCommand(
                @"SELECT c.id_cart, c.Quantity, p.Name, p.Price 
                  FROM Cart_Item c 
                  JOIN Product p ON c.id_product = p.id_product", connection);

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

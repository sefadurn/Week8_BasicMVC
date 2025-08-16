using Microsoft.AspNetCore.Mvc;
using Week8_BasicMVC.Model;

namespace Week8_BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer  // Örnek müşteriyi oluşturuyoruz.
            {
                Id = 1,
                FirstName = "Sefa",
                LastName = "Duran",
                Email = "sefadurn@patika.com"
            };
            var orders = new List<Order>   // Örnek sipariş listesini oluşturuyoruz.
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 30000, Quantity = 12 },
                new Order { Id = 101, ProductName = "Klavye", Price = 7000, Quantity = 48 },
                new Order { Id = 101, ProductName = "Kulaklık", Price = 5000, Quantity = 32 },
            };

            var viewModel = new CustomerOrderViewModel
            { // ViewModel'i dolduruyoruz.
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);  // View'a ViewModel'i gönderiyoruz.
        }
    }
}

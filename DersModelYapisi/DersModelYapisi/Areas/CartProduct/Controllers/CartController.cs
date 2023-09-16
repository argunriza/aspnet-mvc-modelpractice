using DersModelYapisi.DTO;
using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;



namespace DersModelYapisi.Areas.CartProduct.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            Product product1 = new Product{Id = 1,Name = "Shirt", Price = 200};
            Product product2 = new Product{Id = 2,Name = "Sweat", Price = 400};
            Product product3 = new Product{Id = 3,Name = "Jean", Price = 500};

            Models.CartProduct cartProduct1 = new Models.CartProduct { Id = 1, Price = 200, Product = product1, Quantity = 2 };
            Models.CartProduct cartProduct2 = new Models.CartProduct { Id = 2, Price = 400, Product = product2, Quantity = 3 };
            Models.CartProduct cartProduct3 = new Models.CartProduct { Id = 3, Price = 500, Product = product3, Quantity = 4 };

            List<Models.CartProduct> cartProducts = new List<Models.CartProduct>
            {
                cartProduct1,
                cartProduct2,
                cartProduct3
            };

            CartProductCalculator calculator = new CartProductCalculator();

            foreach (Models.CartProduct cartProduct in cartProducts)
            {
                cartProduct.TotalPrice = calculator.CalculateTotalPrice(cartProduct);
            }

            return View(cartProducts);
        }
    }
}

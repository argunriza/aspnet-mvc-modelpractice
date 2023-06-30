using DersModelYapisi.Models;

namespace DersModelYapisi.Areas.CartProduct.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

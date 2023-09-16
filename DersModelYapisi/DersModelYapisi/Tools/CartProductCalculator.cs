using DersModelYapisi.Areas.CartProduct.Models;

namespace DersModelYapisi.DTO
{
    public class CartProductCalculator
    {
        public decimal CalculateTotalPrice(CartProduct cartProduct)
        {
            decimal totalPrice = cartProduct.Quantity * cartProduct.Price;
            return totalPrice;
        }
    }
}

using ASP_Homework_Product.Models;

namespace ASP_Homework_Product
{
    public interface ICartsRes
    {
        void Add(Product product, string userId);
        Cart TryGetByUserId(string userId);
    }
}
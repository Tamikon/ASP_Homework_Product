using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductList productList;

        public ProductController()
        {
            productList = new ProductList();
        }
        public string Index(int id)
        {
            var product = productList.TryGetById(id);
            if (product == null)
            {
                return "Ноутбука нет на складе";
            }
            return $"{product}\n{product.Description}";
        }
    }
}

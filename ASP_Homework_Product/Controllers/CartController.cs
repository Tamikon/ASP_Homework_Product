using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductList productList;

        public CartController()
        {
            productList = new ProductList();
        }

        public IActionResult Index()
        {
            var cart = CartsRes.TryGetByUserId(Constants.UserId);
            return View(cart);
        }
        
        public IActionResult Add(int productId)
        {
            var product = productList.TryGetById(productId);
            CartsRes.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}

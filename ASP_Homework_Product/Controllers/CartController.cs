using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductList productList;
        private readonly CartsRes cartsRes;

        public CartController(ProductList productList, CartsRes cartsRes)
        {
            this.productList = productList;
            this.cartsRes = cartsRes;
        }

        public IActionResult Index()
        {
            var cart = cartsRes.TryGetByUserId(Constants.UserId);
            return View(cart);
        }
        
        public IActionResult Add(int productId)
        {
            var product = productList.TryGetById(productId);
            cartsRes.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}

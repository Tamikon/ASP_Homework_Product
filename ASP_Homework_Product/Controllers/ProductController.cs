using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductList productList;

        public ProductController(ProductList productList)
        {
            this.productList = productList;
        }

        public ActionResult Index(int id)
        {
            var product = productList.TryGetById(id);
            return View(product);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace ASP_Homework_Product.Controllers
{
    public class OrderController : Controller
    {

        private readonly ICartsRes cartsRes;
        private readonly IOrdersRes ordersRes;

        public OrderController(ICartsRes cartsRes, IOrdersRes ordersRes)
        {
            this.cartsRes = cartsRes;
            this.ordersRes = ordersRes;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buy()
        {
            var existingCart = cartsRes.TryGetByUserId(Constants.UserId);
            ordersRes.Add(existingCart);
            cartsRes.Clear(Constants.UserId);
            return View();
        }
    }
}

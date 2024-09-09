using Microsoft.AspNetCore.Mvc;

namespace YourApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double number1, double number2)
        {
            // Tính trung bình cộng
            double average = (number1 + number2) / 2;

            // Gửi giá trị tính được đến view
            ViewBag.Average = average;
            return View();
        }
    }
}

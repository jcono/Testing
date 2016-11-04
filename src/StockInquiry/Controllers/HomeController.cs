using Microsoft.AspNetCore.Mvc;

namespace StockInquiry.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public IActionResult Index()
        {
            return View();
        }
    }
}

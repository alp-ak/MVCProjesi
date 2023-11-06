using Microsoft.AspNetCore.Mvc;

namespace BilgeShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("urunler/{cateogryName}/{categoryId}")]
        public IActionResult Index(int categoryId)
        {
            ViewBag.CategoryId = categoryId;

            return View();
        }
    }
}

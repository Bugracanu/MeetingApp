using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.AddControllersWithViews
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            var selamlama =

            ViewBag.Selamlama = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Burcu";
            return View();
        }
    }

}
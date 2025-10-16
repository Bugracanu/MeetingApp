using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.AddControllersWithViews
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi günler" : "Günaydın";
            ViewData["UserName"] = "Burcu";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "istanbul, abc merkezi",
                Date = new DateTime(2026, 01, 20, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);
        }
    }

}
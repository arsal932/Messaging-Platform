using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> view()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetBarChart()
        {
            return PartialView();
        }
    }
}

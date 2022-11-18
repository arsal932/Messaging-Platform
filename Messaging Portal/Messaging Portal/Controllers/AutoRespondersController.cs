using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class AutoRespondersController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Page = "AutoResponders";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AutoResponderViewModel autoResponderViewModel)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return PartialView(new AutoResponderViewModel() { Name = "MyAutoResponder", Message = "Get 20% Off.", Time = 10 });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(AutoResponderViewModel autoResponderViewModel)
        {            
            return RedirectToAction("AutoResponders");
        }
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            ViewBag.Page = "AutoResponders";
            return View(new AutoResponderViewModel() { Name = "MyAutoResponder", Message = "Get 20% Off.", Time = 10 });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AutoResponderViewModel autoResponderViewModel)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AutoResponders()
        {
            ViewBag.page = "AutoResponders";
            return View();
        }
        public async Task<IActionResult> GetAutoResponders(string search)
        {
            Thread.Sleep(2000);
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> GetAutoResponderMessage(int AutoResponderID)
        {
            Thread.Sleep(2000);
            ViewBag.AutoResponderID = AutoResponderID;
            return PartialView();
        }
    }
}

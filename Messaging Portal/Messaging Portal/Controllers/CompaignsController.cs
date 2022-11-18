using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class CompaignsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Page = "Compaigns";
            return View();
        }        
        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return PartialView(new CompaignsViewModel() { CompaignName = "MyCompaign" });            
        }
        [HttpPost]
        public async Task<IActionResult> Delete(CompaignsViewModel compaignsViewModel)
        {
            return RedirectToAction("Compaigns");
        }
        [HttpPost]
        public async Task<IActionResult> Create(CompaignsViewModel compaignsViewModel)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Compaigns()
        {
            ViewBag.page = "Compaigns";
            return View();
        }
        public async Task<IActionResult> GetCompaigns(string search)
        {
            Thread.Sleep(2000);
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> GetCompaignMessage(int CompaignID)
        {
            Thread.Sleep(2000);
            ViewBag.CompaignID = CompaignID;
            return PartialView();
        }
    }
}

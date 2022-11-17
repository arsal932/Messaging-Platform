using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class CompaignsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Page="Compaigns";
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CompaignsViewModel compaignsViewModel)
        {
            return PartialView();
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

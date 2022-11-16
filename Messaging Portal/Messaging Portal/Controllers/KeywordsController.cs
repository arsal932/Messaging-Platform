using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class KeywordsController : Controller
    {
        public async Task<IActionResult> List(string auto)
        {
            if(!string.IsNullOrEmpty(auto))
                ViewBag.auto=auto;
            ViewBag.page = "Keywords";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            Thread.Sleep(2000);
            List<KeywordsViewModel> Keywords = new List<KeywordsViewModel>();
            Keywords.Add(new KeywordsViewModel() { Name = "Subscribe", Contacts = 12, List = "Corona Notification", Creation_Date = DateTime.Now, Triggers = 2 });
            Keywords.Add(new KeywordsViewModel() { Name = "Unscubcribe", Contacts = 45, List = "Exam Notification", Creation_Date = DateTime.Now, Triggers = 3 });
            Keywords.Add(new KeywordsViewModel() { Name = "Help", Contacts = 13, List = "Corona Notification", Creation_Date = DateTime.Now, Triggers = 4 });
            Keywords.Add(new KeywordsViewModel() { Name = "Package", Contacts = 1, List = "Exam Notification", Creation_Date = DateTime.Now, Triggers = 5 });
            return PartialView(Keywords);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> Create(KeywordsViewModel keywordsViewModel)
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return PartialView(new KeywordsViewModel() { Name = "Subscribe", Frequency = 12, Auto_Confirmation_Message = "thanks for subscribing us", Free_Compliance_Message = "Reply stop to stop." });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(KeywordsViewModel keywordsViewModel)
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return PartialView(new KeywordsViewModel() { Name = "Subscribe", Frequency = 12, Auto_Confirmation_Message = "thanks for subscribing us", Free_Compliance_Message = "Reply stop to stop." });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(KeywordsViewModel keywordsViewModel)
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public async Task<IActionResult> CreateTrigger()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTrigger(TriggerViewModel triggerViewModel)
        {
            return RedirectToAction("List");
        }
        public async Task<IActionResult> TriggersList()
        {
            //ViewBag.page = "Keywords";
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> GetTriggersList()
        {
            Thread.Sleep(2000);
            List<TriggerViewModel> Triggers = new List<TriggerViewModel>();
            Triggers.Add(new TriggerViewModel() { TriggerName = "Trigger 1", Message = "Trigger 1 Message" });
            Triggers.Add(new TriggerViewModel() { TriggerName = "Trigger 2", Message = "Trigger 2 Message" });
            Triggers.Add(new TriggerViewModel() { TriggerName = "Trigger 3", Message = "Trigger 3 Message" });
            Triggers.Add(new TriggerViewModel() { TriggerName = "Trigger 4", Message = "Trigger 4 Message" });
            return PartialView(Triggers);
        }
        [HttpGet]
        public async Task<IActionResult> EditTrigger()
        {
            return PartialView(new TriggerViewModel() { TriggerName = "Subscribe", Message = "Thanks for subscribing us." });
        }
        [HttpPost]
        public async Task<IActionResult> EditTrigger(TriggerViewModel triggerViewModel)
        {
            return RedirectToAction("List",new { auto="t"});
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTrigger()
        {
            return PartialView(new TriggerViewModel() { TriggerName = "Subscribe", Message="Thanks for subscribing us." });
        }
        [HttpPost]
        public async Task<IActionResult> DeleteTrigger(TriggerViewModel triggerViewModel)
        {
            return RedirectToAction("List", new { auto = "t" });
        }
    }
}

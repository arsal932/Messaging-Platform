using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class SubscribersController : Controller
    {
        public async Task<IActionResult> List()
        {
            return View();
        }
        public async Task<IActionResult> getList()
        {
            Thread.Sleep(2000);
            List<TopicsViewModel> Topics = new List<TopicsViewModel>();
            Topics.Add(new TopicsViewModel() { Name="Corona Notification",Active=12,Invalid=2,CreationDate=DateTime.Now,Opt_Outs=0,TotalContacts=34});
            Topics.Add(new TopicsViewModel() { Name = "New Feature", Active = 122, Invalid = 5, CreationDate = DateTime.Now, Opt_Outs = 0, TotalContacts = 332 });
            Topics.Add(new TopicsViewModel() { Name = "New Customers", Active = 152, Invalid = 3, CreationDate = DateTime.Now, Opt_Outs = 0, TotalContacts = 323 });
            Topics.Add(new TopicsViewModel() { Name = "Exam Notification", Active = 172, Invalid = 12, CreationDate = DateTime.Now, Opt_Outs = 0, TotalContacts = 3654 });
            return PartialView(Topics);
        }
        public async Task<IActionResult> createContact()
        {
            return PartialView();
        }
        public async Task<IActionResult> createList()
        {
            return PartialView();
        }
        public async Task<IActionResult> ImportContacts()
        {
            return PartialView();
        }
        public async Task<IActionResult> MapFields()
        {
            return PartialView();
        }

    }
}

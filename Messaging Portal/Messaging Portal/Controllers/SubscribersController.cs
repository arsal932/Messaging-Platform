using Messaging_Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers
{
    public class SubscribersController : Controller
    {
        public async Task<IActionResult> List()
        {
            ViewBag.page = "Subscribers";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> getList()
        {
            Thread.Sleep(2000);
            List<TopicsViewModel> Topics = new List<TopicsViewModel>();
            Topics.Add(new TopicsViewModel() { Name = "Corona Notification", Active = 12, Invalid = 2, CreationDate = DateTime.Now, Opt_Outs = 0, TotalContacts = 34 });
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
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return RedirectToAction("List");
        }
        public async Task<IActionResult> ImportContacts()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int list)
        {
            return PartialView(new TopicsViewModel() { Name = "Corona Notification" });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TopicsViewModel topicsViewModel)
        {
            return RedirectToAction("List");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int list)
        {
            return PartialView(new TopicsViewModel() { Name = "Corona Notification" });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(TopicsViewModel topicsViewModel)
        {
            return RedirectToAction("List");
        }
        public async Task<IActionResult> ContactsList(int? SusbcriberList)
        {
            ViewBag.page = "Contacts";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> getContactsList(int? SusbcriberList)
        {
            Thread.Sleep(2000);
            List<ContactViewModel> Contacts = new List<ContactViewModel>();
            Contacts.Add(new ContactViewModel() { FirstName="Mahaz",LastName="khan",Address="H10 -Islamabad",Email= "Mahaz@gmail.com", Phone="+42-12342123",DateOfBirth=DateTime.Now});
            Contacts.Add(new ContactViewModel() { FirstName = "Tanveer", LastName = "khan", Address = "G10 -Islamabad", Email = "Tanveer@gmail.com", Phone = "+42-12366123", DateOfBirth = DateTime.Now });
            Contacts.Add(new ContactViewModel() { FirstName = "Sadiq", LastName = "khan", Address = "F10 -Islamabad", Email = "Sadiq@gmail.com", Phone = "+42-12316523", DateOfBirth = DateTime.Now });

            return PartialView(Contacts);
        }
        [HttpGet]
        public async Task<IActionResult> EditContact(int Contact)
        {
            return PartialView(new ContactViewModel() { FirstName = "Mahaz", LastName = "khan", Address = "H10 -Islamabad", Email = "Mahaz@gmail.com", Phone = "+42-12342123", DateOfBirth = DateTime.Now });
        }
        [HttpPost]
        public async Task<IActionResult> EditContact(ContactViewModel ContactViewModel)
        {
            return RedirectToAction("ContactsList");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteContact(int Contact)
        {
            return PartialView(new ContactViewModel() { FirstName = "Mahaz", LastName = "khan", Address = "H10 -Islamabad", Email = "Mahaz@gmail.com", Phone = "+42-12342123", DateOfBirth = DateTime.Now });
        }
        [HttpPost]
        public async Task<IActionResult> DeleteContact(ContactViewModel ContactViewModel)
        {
            return RedirectToAction("ContactsList");
        }
    }
}

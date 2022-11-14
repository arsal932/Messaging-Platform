using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers;
public class InboxController : Controller
{
    public InboxController()
    {

    }
    [HttpGet]
    public async Task<IActionResult> Chats()
    {
        return View();
    }
    
    public async Task<IActionResult> getChats(string search)
    {
        Thread.Sleep(2000);
        return PartialView();
    }
    
    public async Task<IActionResult> getChatMessages(int ChatID)
    {
        Thread.Sleep(2000);
        ViewBag.ChatID = ChatID;
        return PartialView();
    }  
    public async Task<IActionResult> NewChat()
    {
        return PartialView();
    }
    //[HttpPost]
    //public async Task<IActionResult> NewChat(BindModelHere)
    //{
    //    return RedirectToAction("");
    //}
}

using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Controllers;
public class InboxController : Controller
{
    public InboxController()
    {

    }
    public async Task<IActionResult> Chats()
    {
        return View();
    }
}

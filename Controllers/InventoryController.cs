// InventoryController.cs
using Microsoft.AspNetCore.Mvc;

namespace JoleraONEDashboard.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult AssetDashboard() => View();
        public IActionResult UserDashboard() => View();
        public IActionResult M365Licenses() => View();
        public IActionResult M365Mailbox() => View();
        public IActionResult M365Sharepoint() => View();
    }
}

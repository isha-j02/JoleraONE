// ManageITController.cs
using Microsoft.AspNetCore.Mvc;

namespace JoleraONEDashboard.Controllers
{
    public class ManageITController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Virtual() => View();
        public IActionResult Physical() => View();
    }
}

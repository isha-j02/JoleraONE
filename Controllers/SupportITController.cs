using Microsoft.AspNetCore.Mvc;

namespace JoleraONEDashboard.Controllers
{
    public class SupportITController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Helpdesk()
        {
            return View();
        }
    }
}

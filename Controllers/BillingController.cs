using Microsoft.AspNetCore.Mvc;

namespace JoleraOneDashboard.Controllers
{
    public class BillingController : Controller
    {
        public IActionResult CurrentMonth()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}

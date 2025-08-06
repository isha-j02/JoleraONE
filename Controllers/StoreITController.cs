using Microsoft.AspNetCore.Mvc;

namespace JoleraOneDashboard.Controllers
{
    public class StoreITController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

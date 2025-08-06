using Microsoft.AspNetCore.Mvc;

namespace JoleraOneDashboard.Controllers
{
    public class ServiceCatalogController : Controller
    {
        public IActionResult Catalog()
        {
            return View();
        }
    }
}

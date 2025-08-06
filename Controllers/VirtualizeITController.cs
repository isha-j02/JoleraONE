using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JoleraONEDashboard.Models;

namespace JoleraOneDashboard.Controllers
{
    public class VirtualizeITController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

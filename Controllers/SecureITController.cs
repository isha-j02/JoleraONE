// SecureITController.cs
using Microsoft.AspNetCore.Mvc;

namespace JoleraONEDashboard.Controllers
{
    public class SecureITController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult EDR() => View();
        public IActionResult Firewall() => View();
        public IActionResult Switch() => View();
        public IActionResult APWiFi() => View();
        public IActionResult Mail() => View();
        public IActionResult UserDefense() => View();
        public IActionResult VulnerabilityResponse() => View();
    }
}

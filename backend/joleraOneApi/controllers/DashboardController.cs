using Microsoft.AspNetCore.Mvc;
using JoleraOneApi.Models;
using System.Collections.Generic;

namespace JoleraOneApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            var data = new StatusData
            {
                Uptime = "99.98%",
                TicketsToday = 12,
                Alerts = new List<Alert>
                {
                    new Alert { Type = "High CPU", Status = "Active" },
                    new Alert { Type = "Low Disk", Status = "Resolved" }
                }
            };

            return Ok(data);
        }
    }
}

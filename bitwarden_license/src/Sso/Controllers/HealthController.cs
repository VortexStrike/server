using Bit.Core.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Bit.Sso.Controllers;

public class HealthController : Controller
{
    [HttpGet("~/healthz")]
    public IActionResult GetHealthZ()
    {
        // TODO: Implement logic for accurate health status of service.
        return Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
    }
}

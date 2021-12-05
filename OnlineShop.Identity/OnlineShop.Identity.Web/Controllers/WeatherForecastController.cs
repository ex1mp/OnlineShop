using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Identity.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/WeatherForecast/Get")]
        public async Task<IActionResult> Get()
        {
            var rng = new Random();
            return Ok("jggjgjh");
        }

        [HttpPost("/api/WeatherForecast/post")]
        public async Task<IActionResult> JDSHF()
        {
            var rng = new Random();
            return Ok("jggjgjh");
        }
    }
}

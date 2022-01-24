using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RequestManagement.Core.Domain.WeatherForecasts.Entities;
using RequestManagement.Core.Domain.WeatherForecasts.Services;

namespace RequestManagement.EndPoints.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {       
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get([FromServices] IRandomForecastsGenerator randomForecastsGenerator)=>
            randomForecastsGenerator.Execute();
    }
}

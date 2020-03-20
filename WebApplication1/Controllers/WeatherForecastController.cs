using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Partly Cloudy", "Fair", "Cloudy", "Rain Shower", "Mostly Cloudy"
        };

        private static readonly string[] Cities = new[]
        {
            "Lisboa", "Porto", "Bragança", "Braga", "Aveiro"
        };

        private static readonly int[] Temperatures = new[]
        {
            11, 24, 23, 13, 13
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            var msg = "Please add into your URL '/' followed by the four first numebers off the Zip Code";
            return msg;

        }

        [HttpGet("{id}")]
        public IEnumerable<WeatherForecast> Get(string id)
        {
            switch (id)
            {
                case "1000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                        City = Cities[0],
                        TemperatureC = Temperatures[0],
                        Summary = Summaries[0]
                    })
                    .ToArray();
                case "4000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                        City = Cities[1],
                        TemperatureC = Temperatures[1],
                        Summary = Summaries[1]
                    })
                    .ToArray();
                case "5300":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                        City = Cities[2],
                        TemperatureC = Temperatures[2],
                        Summary = Summaries[2]
                    })
                    .ToArray();
                case "4615":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                        City = Cities[3],
                        TemperatureC = Temperatures[3],
                        Summary = Summaries[3]
                    })
                    .ToArray();
                case "3020":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                        City = Cities[4],
                        TemperatureC = Temperatures[4],
                        Summary = Summaries[4]
                    })
                    .ToArray();
            }
            return Enumerable.Range(0, 1).Select(index => new WeatherForecast
            {
                Date = DateTime.Parse("2020-03-19T19:12:43.1031855+00:00"),
                City = "ERROR - City Not Found"
            })
            .ToArray();
        }
    }
}
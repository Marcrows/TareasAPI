using Microsoft.AspNetCore.Mvc;

namespace APIProj.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        if (ListWeatherForecast == null || !ListWeatherForecast.Any())
        {
            ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();            
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return ListWeatherForecast;
    }

    [HttpPost]
    public IActionResult Post(WeatherForecast forecast)
    {
        ListWeatherForecast.Add(forecast);
        return Ok("Successfully added a new forecast.");
    }

    [HttpDelete("{index}")]
    public IActionResult Delete(int index)
    {
        if (ListWeatherForecast.Count < index)
        {
            return BadRequest("The given ID is out of bounds.");
        }

        ListWeatherForecast.RemoveAt(index);

        return Ok("Forecast was successfully removed.");
    }
}

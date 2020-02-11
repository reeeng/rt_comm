using System;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public Task<WeatherForecast> SetForecastAsync(WeatherForecast forecast)
        {
            
            return Task.FromResult(new WeatherForecast
            {
                Date = forecast.Date,
                TemperatureC = 1337,
                Summary = Summaries[0]
            });
        }
    }
}

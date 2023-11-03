using Padel.Core.Entities;
using Padel.Core.Interfaces;

namespace DemoPadelBlazoirServer.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]?> GetForecastAsync(DateOnly startDate)
        {
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
            var array = data.ToArray();
            return Task.FromResult(array ?? null);
        }
    }
}
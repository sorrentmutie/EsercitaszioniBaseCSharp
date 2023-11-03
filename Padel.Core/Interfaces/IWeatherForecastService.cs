using Padel.Core.Entities;

namespace Padel.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]?> GetForecastAsync(DateOnly startDate);
    }
}
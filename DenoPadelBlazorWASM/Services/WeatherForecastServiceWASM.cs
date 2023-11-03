using Padel.Core.Entities;
using Padel.Core.Interfaces;
using System.Net.Http.Json;

namespace DenoPadelBlazorWASM.Services;

public class WeatherForecastServiceWASM : IWeatherForecastService
{
    private readonly HttpClient http;

    public WeatherForecastServiceWASM(HttpClient http)
    {
        this.http = http;
    }

    public async Task<WeatherForecast[]?> GetForecastAsync(DateOnly startDate)
    {
        return await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");

    }
}

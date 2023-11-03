using DemoPadel.RazorLibrary;
using DenoPadelBlazorWASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Padel.Core;
using Padel.Core.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ISaluto, SalutoBlazorWASM>();
builder.Services.AddScoped<IDatiIstruttori, ServizioIstruttoriBlazorWASM>();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastServiceWASM>();


await builder.Build().RunAsync();

using DRY.DesignPatterns.DecoratorPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete
{
    public class CachingWeatherService : IWeatherService
    {
        private readonly IWeatherService _weatherService;

        public CachingWeatherService(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public string GetWeather(string country)
        {
            var weather = _weatherService.GetWeather(country);
            Console.WriteLine($"Caching Weather in Memory Info : Weather Now in {country} is {weather}");
            return weather;
        }
    }
}

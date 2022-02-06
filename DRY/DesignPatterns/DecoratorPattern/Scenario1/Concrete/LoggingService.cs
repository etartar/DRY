using DRY.DesignPatterns.DecoratorPattern.Scenario1.Abstract;
using System;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete
{
    public class LoggingService : IWeatherService
    {
        private readonly IWeatherService _weatherService;

        public LoggingService(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public string GetWeather(string country)
        {
            var weather = _weatherService.GetWeather(country);
            Console.WriteLine($"Logging Info : Weather Now in {country} is {weather}");
            return weather;
        }
    }
}

using DRY.DesignPatterns.DecoratorPattern.Scenario1.Abstract;
using System.Linq;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete
{
    public class WeatherService : IWeatherService
    {
        public string GetWeather(string country)
        {
            return WeatherDB.Weathers.FirstOrDefault(x => x.Country == country)?.WeatherNow;
        }
    }
}

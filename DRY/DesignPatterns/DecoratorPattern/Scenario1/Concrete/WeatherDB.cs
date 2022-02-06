using System.Collections.Generic;

namespace DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete
{
    public class WeatherDB
    {
        public static IList<Weather> Weathers = new List<Weather>()
        {
            new Weather { WeatherNow = "Hot", Country = "US" },
            new Weather { WeatherNow = "Cold", Country = "UK" },
            new Weather { WeatherNow = "Moderate", Country = "EG" },
        };
    }
}

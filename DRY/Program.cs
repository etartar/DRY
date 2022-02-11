using DRY.ComputingBigCsv;
using DRY.DesignPatterns.DecoratorPattern.Scenario1.Abstract;
using DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete;
using DRY.DesignPatterns.DecoratorPattern.Scenario2.Abstract;
using DRY.DesignPatterns.DecoratorPattern.Scenario2.Concrete;
using DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete;
using DRY.DesignPatterns.StatePattern.Scenario2.Concrete;
using DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete;
using DRY.Loop;
using DRY.ReplaceIFElseStatement;
using DRY.SmartEnumeration;
using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopExample();
            //ReplaceIfElseStatement();
            //SmartEnumeration();
            //CsvReader();
            //VisitorDesignPatternScenario1();
            //DecoratorDesignPatternScenario1();
            //DecoratorDesignPatternScenario2();
            DecoratorDesignPatternScenario3();
            //StateDesignPatternScenario2();

            Console.WriteLine("Hello World!");
        }

        #region LoopExample
        static void LoopExample()
        {
            LoopProgram.ForLoop();
            LoopProgram.ForeachLoop();
            LoopProgram.TupleWithSelectMethod();
            LoopProgram.ExtensionLoop();
        }
        #endregion

        #region [Replace If Else Statement]
        static void ReplaceIfElseStatement()
        {
            var replaceIfElseStatementBad = new ReplaceIFElseStatementBad();
            var replaceIfElseStatementGood = new ReplaceIFElseStatementGood();
            Console.WriteLine(replaceIfElseStatementBad.CalculateTotalAfterDiscount());
            Console.WriteLine(replaceIfElseStatementGood.CalculateTotalAfterDiscount());
        }
        #endregion

        #region Smart Enumeration
        static void SmartEnumeration()
        {
            Console.WriteLine(SmartEnumerationProgram.GetDiscount(EnumSubscription.Premium));
            Console.WriteLine(Subscriptions.Premium.Discount);
        }
        #endregion

        #region CsvReader
        static void CsvReader()
        {
            CsvReaderProgram.CsvReadWithoutPLINQ();
            CsvReaderProgram.CsvReadWithPLINQ();
        }
        #endregion

        #region [Visitor Design Pattern]
        static void VisitorDesignPatternScenario1()
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Sallesman("John");
            school.PerformOperation(visitor2);
        }
        #endregion

        #region Decorator Design Pattern
        static void DecoratorDesignPatternScenario1()
        {
            IWeatherService weatherService = new WeatherService();
            Console.WriteLine(weatherService.GetWeather("UK"));
            Console.WriteLine();

            IWeatherService weatherLogging = new LoggingService(weatherService);
            Console.WriteLine(weatherLogging.GetWeather("US"));
            Console.WriteLine();

            IWeatherService weatherCaching = new CachingWeatherService(weatherService);
            Console.WriteLine(weatherCaching.GetWeather("EG"));
            Console.WriteLine();
        }

        static void DecoratorDesignPatternScenario2()
        {
            Console.WriteLine("Normal siparişiniz hesaplanıyor.");

            IComponent component = new Component();
            Console.WriteLine(component.Operation());

            var decoratorA = new DecoratorA(component);
            Console.WriteLine(decoratorA.Operation());

            var decoratorB = new DecoratorB(component);
            Console.WriteLine(decoratorB.Operation());
        }

        static void DecoratorDesignPatternScenario3()
        {
            var car = new Car("WW", "Golf", 20000m);
            Console.WriteLine($"Price : {car.GetPrice()}");
            Console.WriteLine(car.GetFeatures());
            Console.WriteLine();

            var starterPackageCar = new Starter(car);
            Console.WriteLine($"Price : {starterPackageCar.GetPrice()}");
            Console.WriteLine(starterPackageCar.GetFeatures());
            Console.WriteLine();

            var comfortPackageCar = new Comfort(starterPackageCar);
            Console.WriteLine($"Price : {comfortPackageCar.GetPrice()}");
            Console.WriteLine(comfortPackageCar.GetFeatures());
            Console.WriteLine();

            var premiumPackageCar = new Premium(comfortPackageCar);
            Console.WriteLine($"Price : {premiumPackageCar.GetPrice()}");
            Console.WriteLine(premiumPackageCar.GetFeatures());
            Console.WriteLine();
        }
        #endregion

        #region State Design Pattern
        static void StateDesignPatternScenario2()
        {
            ATMMachine atm = new ATMMachine();
            #region [ATM ye kart takıp çıkarma]
            atm.InsertCard();
            atm.EjectCard();
            Console.WriteLine("******");
            #endregion

            #region [Doğrulanmış pin ile para çekme]
            atm.InsertCard();
            atm.InsertPin(1234);
            atm.RequestCache(1500);
            Console.WriteLine("******");

            atm.InsertCard();
            atm.InsertPin(1234);
            atm.RequestCache(100);
            Console.WriteLine("******");

            atm.InsertCard();
            atm.InsertPin(1234);
            atm.RequestCache(300);
            Console.WriteLine("******");

            atm.InsertCard();
            atm.InsertPin(1234);
            atm.RequestCache(100);
            Console.WriteLine("******");

            atm.InsertCard();
            atm.InsertPin(1234);
            atm.RequestCache(100);
            Console.WriteLine("******");
            #endregion
        }
        #endregion
    }
}

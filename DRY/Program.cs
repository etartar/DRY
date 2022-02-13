using DRY.ComputingBigCsv;
using DRY.DesignPatterns.AbstractFactoryPattern.Scenario1.Concrete;
using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Airway;
using DRY.DesignPatterns.AbstractFactoryPattern.Scenario2.Concrete.Implementations.Railway;
using DRY.DesignPatterns.BuilderPattern.Scenario1.Concrete;
using DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete;
using DRY.DesignPatterns.BuilderPattern.Scenario2.Concrete.PackageBuilders.Implementations;
using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete;
using DRY.DesignPatterns.ChainOfResponsibilityPattern.Scenario1.Concrete.Handlers;
using DRY.DesignPatterns.DecoratorPattern.Scenario1.Abstract;
using DRY.DesignPatterns.DecoratorPattern.Scenario1.Concrete;
using DRY.DesignPatterns.DecoratorPattern.Scenario2.Abstract;
using DRY.DesignPatterns.DecoratorPattern.Scenario2.Concrete;
using DRY.DesignPatterns.DecoratorPattern.Scenario3.Concrete;
using DRY.DesignPatterns.FactoryPattern.Scenario1.Concrete;
using DRY.DesignPatterns.FactoryPattern.Scenario2.Abstract;
using DRY.DesignPatterns.FactoryPattern.Scenario2.Concrete;
using DRY.DesignPatterns.FactoryPattern.Scenario2.Enum;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Abstract;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete;
using DRY.DesignPatterns.FactoryPattern.Scenario3.Concrete.Implementations.Garanti;
using DRY.DesignPatterns.StatePattern.Scenario2.Concrete;
using DRY.DesignPatterns.StrategyPattern.Scenario1.Concrete;
using DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete;
using DRY.DesignPatterns.StrategyPattern.Scenario2.Concrete.Strategies;
using DRY.DesignPatterns.StrategyPattern.Scenario2.Enums;
using DRY.DesignPatterns.VisitorPattern.Scenario1.Concrete;
using DRY.Loop;
using DRY.ReplaceIFElseStatement;
using DRY.SmartEnumeration;
using System;
using System.Text;
using PrototypeOrder = DRY.DesignPatterns.PrototypePattern.Scenario1.Concrete.Order;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryDesignPatternScenario1();

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

        #region Builder Design Pattern
        static void BuilderDesignPatternScenario1()
        {
            var invoiceBuilder = new InvoiceBuilder();
            invoiceBuilder.SetCompanyName("ET Software Company")
                            .SetVat("200.100.300")
                            .SetItem(new ItemBuilder().SetItemName("Item 1").SetAmount(100).Builder())
                            .SetItem(new ItemBuilder().SetItemName("Item 2").SetAmount(200).Builder())
                            .SetItem(new ItemBuilder().SetItemName("Item 3").SetAmount(300).Builder())
                            .SetOthersInformations("it is a new information");

            Invoice invoice = invoiceBuilder.Builder();
        }

        static void BuilderDesignPatternScenario2()
        {
            Console.WriteLine("Subscription package builder.");

            PackageDirector packageDirector = new PackageDirector();
            
            packageDirector.SetPackageBuilder(new FreePackageBuilder());
            PackageDetails(packageDirector.BuildFreeMonthlyPackage());

            packageDirector.SetPackageBuilder(new EssentialsPackageBuilder());
            PackageDetails(packageDirector.BuildEssentialsMonthlyEssentials());

            packageDirector.SetPackageBuilder(new ProfessionalPackageBuilder());
            PackageDetails(packageDirector.BuildProfessionalMonthlyEssentials());

            packageDirector.SetPackageBuilder(new PremiumPackageBuilder());
            PackageDetails(packageDirector.BuildPremiumYearlyEssentials());
        }

        static void PackageDetails(SubscriptionPackage subscriptionPackage)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------");
            stringBuilder.AppendLine($"Duration Type : {subscriptionPackage.DurationType}");
            stringBuilder.AppendLine($"Package Type : {subscriptionPackage.PackageType}");
            stringBuilder.AppendLine($"Contact Counts : {subscriptionPackage.Contacts}");
            stringBuilder.AppendLine($"Unit Price : {subscriptionPackage.UnitPrice}");
            stringBuilder.AppendLine($"Total Price : {subscriptionPackage.TotalPrice}");
            stringBuilder.AppendLine($"PaymentTransactionsFees : {subscriptionPackage.PaymentTransactionFees}");
            stringBuilder.AppendLine("------");

            Console.WriteLine(stringBuilder.ToString());
        }
        #endregion

        #region Prototype Design Pattern
        static void PrototypeDesignPatternScenario1()
        {
            PrototypeOrder mainOrder = PrototypeOrder.Create("Emir TARTAR", "emirtartar.com", 2500M);
            OrderInformation(mainOrder);

            var cloneOrder1 = mainOrder.Clone();
            OrderInformation((PrototypeOrder)cloneOrder1);

            var cloneOrder2 = mainOrder.Clone();
            OrderInformation((PrototypeOrder)cloneOrder2);

            var cloneOrder3 = mainOrder.Clone();
            OrderInformation((PrototypeOrder)cloneOrder3);
        }

        static void OrderInformation(PrototypeOrder order)
        {
            Console.WriteLine("----");
            Console.WriteLine($"Id : {order.Id}");
            Console.WriteLine($"Contact : {order.Contact}");
            Console.WriteLine($"Address : {order.Address}");
            Console.WriteLine($"Total Price : {order.TotalPrice}");
            Console.WriteLine("----");
        }
        #endregion

        #region ChainOfResponsibility Design Pattern
        static void ChainOfResponsibilityScenario1()
        {
            var memberControlHandler = new MemberControlHandler();
            var pandemicControlHandler = new PandemicControlHandler();
            var roomControlHandler = new RoomControlHandler();
            var rentARoomHandler = new RentARoomHandler();

            memberControlHandler.SetNext(pandemicControlHandler)
                                .SetNext(roomControlHandler)
                                .SetNext(rentARoomHandler);

            var result = memberControlHandler.Handle(new RentARoomModel
            {
                Name = "Emir",
                PersonCount = 2,
                RoomNumber = 1,
            });

            Console.ReadKey();
        }
        #endregion

        #region Strategy Design Pattern
        static void StrategyDesignPatternScenario1()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ExecuteContext();

            context = new Context(new ConcreteStrategyB());
            context.ExecuteContext();

            context = new Context(new ConcreteStrategyC());
            context.ExecuteContext();
        }

        static void StrategyDesignPatternScenario2()
        {
            PaymentOperation paymentOperation = new PaymentOperation();

            PaymentType paymentType = PaymentType.CreditCard;

            if (paymentType == PaymentType.MailOrder)
                paymentOperation.SetPayment(new MailOrderStrategy());
            else if (paymentType == PaymentType.BankTransfer)
                paymentOperation.SetPayment(new BankTransferStrategy());
            else if (paymentType == PaymentType.CreditCard)
                paymentOperation.SetPayment(new CreditCardStrategy());
            else
                throw new NotImplementedException("Ödeme türü bulunamadı.");

            paymentOperation.MakePayment();
        }
        #endregion

        #region Factory Design Pattern
        static void FactoryDesignPatternScenario1()
        {
            var bmw = CarFactory.CreateCar("BMW", "Siyah", 240000, 2016, true);
            var audi = CarFactory.CreateCar("Audi", "Beyaz", 194000, 2018, false);

            bmw.ShowCarInfo();
            Console.WriteLine();
            audi.ShowCarInfo();
        }

        static void FactoryDesignPatternScenario2()
        {
            DriverLicence driverLicence = DrivingSchoolFactory.CreateLicence(DriverLicenceType.E);
            driverLicence.Drive();
        }

        static void FactoryDesignPatternScenario3()
        {
            IPayInputModel payInputModel = new GarantiPayInputModel
            {
                CardNumber = "12350259",
                Price = 1299.99M,
                OrderNumber = Guid.NewGuid().ToString(),
            };

            IPayment payment = PaymentFactory.InitializePayment(payInputModel.CardNumber);

            payment.Pay(payInputModel);
        }
        #endregion

        #region Abstract Factory Design Pattern
        static void AbstractFactoryDesignPatternScenario1()
        {
            var audiFactory = new AudiFactory();
            var bmwFactory = new BMWFactory();

            var audiCar = audiFactory.CreateCar("Beyaz", 194000, 2018, false);
            var bmwCar = bmwFactory.CreateCar("Kırmızı", 234000, 2021, true);

            var audiMotorCycle = audiFactory.CreateMotorCycle("Yarış Motoru", "Siyah", 125000, 2021);
            var bmwMotorCycle = bmwFactory.CreateMotorCycle("Cadde Motoru", "Mavi", 135000, 2021);

            audiCar.ShowCarInfo();
            Console.WriteLine();
            audiMotorCycle.ShowMotorCycleInfo();
            Console.WriteLine();
            bmwCar.ShowCarInfo();
            Console.WriteLine();
            bmwMotorCycle.ShowMotorCycleInfo();
        }

        static void AbstractFactoryDesignPatternScenario2()
        {
            RailwayFactory railwayFactory = new RailwayFactory();
            var train = railwayFactory.CreateVehicle();
            var trainStation = railwayFactory.CreateStation();
            train.GetSpeed();
            trainStation.DistanceToCityCenter();
            
            Console.WriteLine();

            AirwayFactory airwayFactory = new AirwayFactory();
            var plane = airwayFactory.CreateVehicle();
            var airwayStation = airwayFactory.CreateStation();
            plane.GetSpeed();
            airwayStation.DistanceToCityCenter();
        }
        #endregion
    }
}

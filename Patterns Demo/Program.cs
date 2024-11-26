using Patterns_Demo.Adapter_Pattern_Example;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;
using Patterns_Demo.Behavioral_Patterns.Command_Pattern.Services;
using Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Models;
using Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Services;
using Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Services;
using Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Services;
using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;
using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;
using Patterns_Demo.Bridge_Pattern_Example;
using Patterns_Demo.Bridge_Pattern_Example.Models;
using Patterns_Demo.Bridge_Pattern_Example.Services;
using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Interfaces;
using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Services;
using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Models;
using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;
using Patterns_Demo.Creational_Patterns.Singleton_Pattern.Services;
using Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;
using Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Abstractions;
using Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Services;
using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;
using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;
using Patterns_Demo.SOLID_Patterns.Single_Responsiblity_Principle.Services;
using Patterns_Demo.Structural_Patterns.Adapter_Pattern.Services;
using Patterns_Demo.Structural_Patterns.Decorator_Pattern.Services;
using System.Data;
using System.Net;

namespace Patterns_Demo;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Creational Patterns

        // 1.
        //FactoryMethodPatternExample();
        //FactoryMethodPatternExample2();
        //FactoryMethodPatternExample3();

        // 2.
        //AbstractFactoryPatternExample();

        // 3.
        //SingletonPatternExample();

        #endregion

        #region Structural Patterns

        // 1.
        //AdapterPatternExample();
        //AdapterPatternExample2();

        // 2.
        //BridgePatternExample();

        // 4.
        //DecoratorPatternExample();

        #endregion

        #region Behavioral Patterns

        // 2.
        CommandPatternExample();

        // 3.
        //IteratorPatternExample();

        // 6.
        //ObserverPatternExample();
        //ObserverPatternExample2();

        // 8.
        //StrategyPatternExample();
        //StrategyPatternExample2();

        // 9.
        //TemplatePatternExample();
        //TemplatePatternExample2();

        #endregion

        #region SOLID Patterns

        // 1.
        SingleResponsibilityPrincipleExample();

        // 2.
        OpenClosedPrincipleExample();
        OpenClosedPrincipleExample2();

        // 3.
        LiskovSubstitutionPrincipleExample();
        LiskovSubstitutionPrincipleExample2();

        // 4.
        InterfaceSegregationPrincipleExample();

        // 5.
        DependencyInversionPrincipleExample();

        #endregion

    }

    private static void CommandPatternExample()
    {
        // The client code can parameterize an invoker with any commands.
        Invoker invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Say Hi!"));
        Receiver receiver = new Receiver();
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

        invoker.DoSomethingImportant();
    }

    private static void ObserverPatternExample2()
    {
        // The client code.
        var subject = new Subject();
        var observerA = new ConcreteObserverA();
        subject.Attach(observerA);

        var observerB = new ConcreteObserverB();
        subject.Attach(observerB);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        subject.Detach(observerB);

        subject.SomeBusinessLogic();
    }

    private static void ObserverPatternExample()
    {
        TrainSignal trainSignal = new TrainSignal();
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        trainSignal.HereComesATrain();
    }

    private static void SingletonPatternExample()
    {
        Logger.TheInstance.InitializeLogging();
        Logger.TheInstance.LogMessage("I love static data");
        Logger.TheInstance.LogMessage("static data exists before and after main()");
        Logger.TheInstance.LogMessage("When I think static, I think memory created by the compiler");
        Logger.TheInstance.ShutdownLogging();
    }

    private static void FactoryMethodPatternExample3()
    {
        var person = PersonFactoryWithoutConditionals.CreatePerson<Manager>(EnumPerson.Manager);
        person.Invoke();
    }

    private static void FactoryMethodPatternExample2()
    {
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            var person = PersonFactory.GetPerson(input).Name;
            Console.WriteLine(person);
        }
    }

    private static void TemplatePatternExample2()
    {
        AlgorithmBase algorithmBase = new ConcreteAlgorithmA();
        algorithmBase.TemplateMethod();
        algorithmBase = new ConcreteAlgorithmB();
        algorithmBase.TemplateMethod();
    }

    private static void StrategyPatternExample2()
    {
        Client client = new Client();
        client.Strategy = new ConcreteStrategyA();
        client.CallAlgorithm();
        client.Strategy = new ConcreteStrategyB();
        client.CallAlgorithm();
    }

    private static void StrategyPatternExample()
    {
        Context context = new Context(new Strategy1()); // we inject the Strategy1
        context.ExecuteTheStrategy(); // it will print “Execute strategy 1”;
        context = new Context(new Strategy2()); // we inject the Strategy2
        context.ExecuteTheStrategy(); // it will print “Execute strategy 2”
    }

    private static void FactoryMethodPatternExample()
    {
        Console.WriteLine("Factory with usual switch statement:");
        FactoryWithSwitch.FactoryMethod("a");

        Console.WriteLine("Factory with polymorphism instead of usual switch statement:");
        new FactoryWithPolymorphism(new MA()).FactoryMethod();
    }

    private static void LiskovSubstitutionPrincipleExample2()
    {
        // Class violating LSP
        Animal animalVLSP = new LSPAnimalVLSP();
        animalVLSP.AnimalSound(new List<Animal> { new Mouse { Name="mouse" } });
        animalVLSP.MakeSound();
        animalVLSP.LegCount();

        // Class after applying LSP
        Animal animalWLSP = new LSPAnimalWLSP();
        animalWLSP.AnimalSound(new List<Animal> { new Lion { Name="lion" } });
        animalWLSP.MakeSound();
        animalWLSP.LegCount();
    }

    private static void DependencyInversionPrincipleExample()
    {
        HttpService connection = new();
        var url = "https://randomuser.me/api/";
        var response = connection.Request(url, HttpMethod.Get.Method, new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        if (response.Status.Equals(HttpStatusCode.OK))
        {
            Console.WriteLine(response.Result.Content.ToString());
        }
    }

    private static void InterfaceSegregationPrincipleExample()
    {
        // 4. Class violating ISP
        ICircleVISP circleVISP = new CircleVISP();
        circleVISP.DrawCircle();

        ISquareVISP squareVISP = new SquareVISP();
        squareVISP.DrawSquare();

        IRectangleVISP rectangleVISP = new RectangleVISP();
        rectangleVISP.DrawRectangle();

        ITriangleVISP triangleVISP = new TriangleVISP();
        triangleVISP.DrawTriangle();

        // Class follows ISP
        IShapeWISP shape = new Circle();
        shape.Draw();

        shape = new Square();
        shape.Draw();

        shape = new Rectangle();
        shape.Draw();

        shape = new Triangle();
        shape.Draw();

        shape = new CustomShape();
        shape.Draw();
    }

    private static void OpenClosedPrincipleExample2()
    {
        // OCP Example 2 Violating OCP
        DiscountVOCP discountVOCP = new DiscountVOCP();
        discountVOCP.Price = 100;

        discountVOCP.Customer = "Danish";
        Console.WriteLine(discountVOCP.GiveDiscount());

        discountVOCP.Customer = "fav";
        Console.WriteLine(discountVOCP.GiveDiscount());

        discountVOCP.Customer = "vip";
        Console.WriteLine(discountVOCP.GiveDiscount());

        // Example 2 after applying OCP
        DiscountWOCP discountWOCP = new SuperVIPDiscount();
        discountWOCP.Price = 100;

        discountWOCP.Customer = "fav";
        Console.WriteLine(discountWOCP.GetDiscount());

        discountWOCP = new VIPDiscount();
        discountWOCP.Customer = "vip";
        Console.WriteLine(discountWOCP.GetDiscount());
    }

    private static void OpenClosedPrincipleExample()
    {
        // Class violating OCP
        AnimalVOCP animalVOCP = new AnimalVOCP();
        animalVOCP.AnimalSound(new List<AnimalVOCP> { new AnimalVOCP("lion") });

        // Class after applying OCP
        AnimalWOCP animalWOCP = new LionWOCP();
        animalWOCP.AnimalSound(new List<AnimalWOCP> { new LionWOCP() });
    }

    private static void SingleResponsibilityPrincipleExample()
    {
        // Class violating SRP
        AnimalVSRP animalVSRP = new AnimalVSRP("lion");
        animalVSRP.SaveAnimal(animalVSRP);

        // Class after applying SRP
        AnimalWSRP animalWSRP = new AnimalWSRP("sheep");
        AnimalDB animalDB = new AnimalDB();
        animalDB.SaveAnimal(animalWSRP);
    }

    private static void TemplatePatternExample()
    {
        // define a skeleton of algorithms of an operation
        Etl algorithmBase = new ExcelToWord();
        algorithmBase.Execute();
        algorithmBase = new WordToExcel();
        algorithmBase.Execute();
    }

    private static void AbstractFactoryPatternExample()
    {
        CarCompany carCompany = new CarCompany();
        var teslaCar = carCompany.ProduceVehicle(nameof(TeslaCar));
        teslaCar.Manufacture();

        var teslabike = carCompany.ProduceVehicle(nameof(TeslaBike));
        teslabike.Manufacture();
    }

    private static void IteratorPatternExample()
    {
        Customer cust = new Customer();
        // user should not be able to add items to this collection but only iterate it
        cust.Add(new Address() { Type = "o" });

        foreach (var x in cust.GetAddresses())
        {
            // read all addresses here
            Console.WriteLine(x.ToString());
        }
    }

    private static void DecoratorPatternExample()
    {
        var regularOrder = new RegularOrder();
        Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
        Console.WriteLine();

        var preOrder = new PreOrder();
        Console.WriteLine(preOrder.CalculateTotalOrderPrice());
        Console.WriteLine();

        var premiumPreorder = new PremiumPreorder(preOrder);
        Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());
    }

    private static void LiskovSubstitutionPrincipleExample()
    {
        // Class violating LSP
        Bird bird = new Duck();
        bird.CanFly();
        bird.CanSwim();

        Console.WriteLine();
        Console.WriteLine("===============================================");
        Console.WriteLine();

        // Class after applying LSP
        bird = new ToyDuck();
        bird.CanFly();
        bird.CanSwim();
    }

    private static void BridgePatternExample()
    {
        // Implementation of Bridge Pattern (Structural Pattern) 
        FilterRequest filterRequest = new(); // Filters.cs from front end
        Abstraction ab = new(); // DI this in startup.cs instead of IFilters,Filters.cs

        // Set implementation and call
        ab.Implementor = new Filters();
        var result1 = ab.Operation(filterRequest);

        // Change implemention and call
        ab.Implementor = new UpdatedFilters();
        var result2 = ab.Operation(filterRequest);

        Console.WriteLine("Filtered results");

        if (result1 != null)
        {
            foreach (var item in result1)
            {
                Console.WriteLine(item.Value);
            }
        }

        Console.WriteLine("Updated Filter results");

        if (result2 != null)
        {
            foreach (var item in result2)
            {
                Console.WriteLine(item.Value);
            }
        }
    }

    private static void AdapterPatternExample()
    {
        // Example of Adapter Design Pattern 
        // Regardless of datasource we get the Data
        DataAdapter adapter = new DataAdaptee(SourceType.File);
        adapter.Fill();
        Console.WriteLine(adapter.Data);

        adapter = new DataAdaptee(SourceType.Json);
        adapter.Fill();
        Console.WriteLine(adapter.Data);

        adapter = new DataAdaptee(SourceType.Xml);
        adapter.Fill();
        Console.WriteLine(adapter.Data);

        adapter = new DataAdaptee(SourceType.Api);
        adapter.Fill();
        Console.WriteLine(adapter.Data);

        adapter = new DataAdaptee(SourceType.Sql);
        adapter.Fill();
        Console.WriteLine(adapter.Data);
    }

    private static void AdapterPatternExample2()
    {
        // make a connector for incompatible classes
        // used for some third party classes when integrated within our system
        IReport rep = new ExcelReport();
        rep.Export();
        rep = new WordReport();
        rep.Export();
        rep = new AdapterPdf();
        rep.Export();
    }
}
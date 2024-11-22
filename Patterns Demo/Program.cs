using Patterns_Demo.Adapter_Pattern_Example;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;
using Patterns_Demo.Adapter_Pattern_Example.Services;
using Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Models;
using Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Services;
using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;
using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;
using Patterns_Demo.Bridge_Pattern_Example;
using Patterns_Demo.Bridge_Pattern_Example.Models;
using Patterns_Demo.Bridge_Pattern_Example.Services;
using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Interfaces;
using Patterns_Demo.Creational_Patterns.Abstract_Factory_Pattern.Services;
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;
using Patterns_Demo.Structural_Patterns.Adapter_Pattern.Services;
using Patterns_Demo.Structural_Patterns.Decorator_Pattern.Services;

namespace Patterns_Demo;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Creational Patterns

        // 2.
        AbstractFactoryPatternExample();

        #endregion

        #region Structural Patterns

        // 1.
        AdapterPatternExample();
        AdapterPatternExample2();

        // 2.
        BridgePatternExample();

        // 4.
        DecoratorPatternExample();

        #endregion

        #region Behavioral Patterns

        // 2.
        IteratorPatternExample();

        // 9.
        TemplatePatternExample();

        #endregion

        #region SOLID Patterns

        // 4.
        LiskovSubstitutionPrincipleExample();

        #endregion

    }

    private static void TemplatePatternExample()
    {
        // define a skeleton of algorithms of an operation
        Etl etl = new ExcelToWord();
        etl.Execute();
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
        cust.Add(new Address() {Type = "o"});
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
        Bird bird = new Duck();
        bird.CanFly();
        bird.CanSwim();
        Console.WriteLine();
        Console.WriteLine("===============================================");
        Console.WriteLine();
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
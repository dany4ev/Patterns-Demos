using Patterns_Demo.Adapter_Pattern_Example;
using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo;

internal class Program
{
    private static void Main(string[] args)
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
}
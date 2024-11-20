using System.Diagnostics;
using Newtonsoft.Json;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example.Services;

public class JsonDataSource : IDataSource
{
    public Root? GetData()
    {
        string path = $"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule?.FileName)?
            .Replace(@"\bin\Debug\net8.0", "")}\\Adapter Pattern Example\\Data Sources\\randomuser.json";
        var jsonFile = File.ReadAllText(path);
        var result = JsonConvert.DeserializeObject<Root>(jsonFile);
        return result;
    }
}
using Newtonsoft.Json;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example.Services;

public class ApiDataSource : IDataSource
{
    public Root? GetData()
    {
        var client = new HttpClient();
        var url = "https://randomuser.me/api/";
        var response = client.GetAsync(url).Result;
        var result = new Root();

        if (response.IsSuccessStatusCode)
        {
            var data = response.Content.ReadAsStringAsync().Result;
            result = JsonConvert.DeserializeObject<Root>(data);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }

        return result;
    }
}
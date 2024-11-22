using System.Diagnostics;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example.Services;

public class XmlDataSource : IDataSource
{
    public Root? GetData()
    {
        string path = $"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule?.FileName)?
            .Replace(@"\bin\Debug\net8.0", "")}\\Adapter Pattern\\Data Sources\\randomuser.xml";
        var xmlString = File.ReadAllText(path);
        // foreach (XElement level1Element in XElement.Load(path).Elements("root"))
        // {
        //     
        // }
        // XmlSerializer serializer = new XmlSerializer(typeof(Root));
        // var result = (Root)serializer.Deserialize(new StringReader(xmlString))!;
        // return result;
        return JsonConvert.DeserializeObject<Root>(xmlString);
    }
}
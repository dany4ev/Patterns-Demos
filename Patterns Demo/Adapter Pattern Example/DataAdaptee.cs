using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;
using Patterns_Demo.Adapter_Pattern_Example.Services;

namespace Patterns_Demo.Adapter_Pattern_Example;

public class DataAdaptee : DataAdapter
{
    private readonly IDataSource? _dataSource;

    public DataAdaptee(SourceType type)
    {
        _dataSource = type switch
        {
            SourceType.Json => new JsonDataSource(),
            SourceType.Xml => new XmlDataSource(),
            SourceType.File => new FileDataSource(),
            SourceType.Sql => new SqlDataSource(),
            SourceType.Api => new ApiDataSource(),
            _ => _dataSource
        };
    }

    public override void Fill()
    {
        this.Data = _dataSource?.GetData();
    }
}
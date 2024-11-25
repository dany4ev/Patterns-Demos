using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example.Interfaces;

public interface IDataSource
{
    public Root? GetData();
}
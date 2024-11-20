using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example;

public abstract class DataAdapter
{
    public Root? Data { get; set; }
    public abstract void Fill();
}
using Patterns_Demo.Bridge_Pattern_Example.Interfaces;
using Patterns_Demo.Bridge_Pattern_Example.Models;

namespace Patterns_Demo.Bridge_Pattern_Example;

public class Abstraction
{
    protected IFilters? implementor;
    public IFilters? Implementor
    {
        set => implementor = value;
    }

    public virtual IList<FilterRequest>? Operation(FilterRequest request)
    {
        return implementor?.ApplyFilters(request);
    }
}
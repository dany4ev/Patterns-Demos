using Patterns_Demo.Bridge_Pattern_Example.Models;

namespace Patterns_Demo.Bridge_Pattern_Example.Interfaces;

public abstract class IFilters
{
    public abstract IList<FilterRequest>? ApplyFilters(FilterRequest request);
}

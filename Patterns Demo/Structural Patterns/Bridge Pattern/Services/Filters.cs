using Patterns_Demo.Bridge_Pattern_Example.Interfaces;
using Patterns_Demo.Bridge_Pattern_Example.Models;

namespace Patterns_Demo.Bridge_Pattern_Example.Services;

public class Filters : IFilters
{
    public override IList<FilterRequest>? ApplyFilters(FilterRequest request)
    {
        // Apply and use Filters
        Console.WriteLine("Filters logic applied using FilterRequest");
        return
        [
            new FilterRequest
            {
                Value = "Order1"
            },
            new FilterRequest
            {
                Value = "Order2"
            }
        ];
    }
}
using Patterns_Demo.Bridge_Pattern_Example.Interfaces;
using Patterns_Demo.Bridge_Pattern_Example.Models;

namespace Patterns_Demo.Bridge_Pattern_Example.Services;

public class UpdatedFilters : IFilters
{
    public override IList<FilterRequest> ApplyFilters(FilterRequest request)
    {
        // Apply and use updated Filters 
        Console.WriteLine("Updated Filters logic applied using FilterRequest");
        return[new FilterRequest
            {
                Value = "Order3"
            }

        ];
    }
}
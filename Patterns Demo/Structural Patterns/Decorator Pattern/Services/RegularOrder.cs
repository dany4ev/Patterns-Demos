using Patterns_Demo.Structural_Patterns.Decorator_Pattern.Interfaces;

namespace Patterns_Demo.Structural_Patterns.Decorator_Pattern.Services;

public class RegularOrder : OrderBase
{
    public override double CalculateTotalOrderPrice()
    {
        Console.WriteLine("Calculating the total price of a regular order");
        return products.Sum(x => x.Price);
    }
}
using Patterns_Demo.Structural_Patterns.Decorator_Pattern.Interfaces;

namespace Patterns_Demo.Structural_Patterns.Decorator_Pattern.Services;

public class PreOrder : OrderBase
{
    public override double CalculateTotalOrderPrice()
    {
        Console.WriteLine("Calculating the total price of a preorder.");
        return products.Sum(x => x.Price) * 0.9;
    }
}
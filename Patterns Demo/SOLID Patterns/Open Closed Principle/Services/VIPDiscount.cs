using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class VIPDiscount : DiscountWOCP
{
    public override double GetDiscount()
    {
        return base.GetDiscount() * 2;
    }
}

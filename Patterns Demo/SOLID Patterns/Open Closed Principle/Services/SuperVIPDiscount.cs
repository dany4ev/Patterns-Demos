namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class SuperVIPDiscount : VIPDiscount
{
    public override double GetDiscount()
    {
        return base.GetDiscount() * 2;
    }
}

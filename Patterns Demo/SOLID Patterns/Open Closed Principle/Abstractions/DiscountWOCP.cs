namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

// Example 2 after applying OCP
public abstract class DiscountWOCP
{
    public double Price
    {
        get;
        set;
    }
    public string? Customer { get; set; }

    public virtual double GetDiscount()
    {
        return this.Price * 0.2;
    }
}

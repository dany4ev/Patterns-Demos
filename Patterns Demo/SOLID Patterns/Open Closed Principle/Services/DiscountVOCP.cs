namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

// OCP Example 2 Violating OCP
public class DiscountVOCP
{
    public double Price
    {
        get;
        set;
    }

    public string? Customer
    {
        get;
        set;
    }

    //	public double GiveDiscount()
    //	{
    //		return this.price * 0.2;
    //	}

    //When you decide to offer double the 20% discount to VIP customers
    public double GiveDiscount()
    {
        if (this.Customer == "fav")
        {
            return this.Price * 0.2;
        }

        if (this.Customer == "vip")
        {
            return this.Price * 0.4;
        }

        return 0.0;
    }
}

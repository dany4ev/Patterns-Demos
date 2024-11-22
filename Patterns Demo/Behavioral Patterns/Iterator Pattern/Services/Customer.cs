using Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Models;

namespace Patterns_Demo.Behavioral_Patterns.Iterator_Pattern.Services;

public class Customer
{
    public Customer()
    {
        if (this.Addresses == null)
            this.Addresses = new List<Address>();
    }

    private List<Address> Addresses
    {
        get;
        set;
    }

    // To implement iterator here use IEnumerable so 
    // that we can only do reads and no adds to this
    public IEnumerable<Address> GetAddresses()
    {
        return this.Addresses;
    }

    public void Add(Address add)
    {
        foreach (Address a in this.Addresses)
        {
            if (a.Type == add.Type)
            {
                throw new Exception("Not allowed");
            }
        }

        this.Addresses.Add(add);
    }
}
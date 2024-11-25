using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class LionWOCP : AnimalWOCP
{
    public override string MakeSound()
    {
        return "roar";
    }

    public string LionLegCount(AnimalWOCP a)
    {
        return "4";
    }

    public override string LegCount()
    {
        return "4";
    }
}

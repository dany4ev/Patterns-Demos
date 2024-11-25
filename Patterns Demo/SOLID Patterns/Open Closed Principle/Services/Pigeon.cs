using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class PigeonWOCP : AnimalWOCP
{
    public override string MakeSound()
    {
        return "huurr";
    }

    public string PigeonLegCount(AnimalWOCP a)
    {
        return "2";
    }

    public override string LegCount()
    {
        return "2";
    }
}
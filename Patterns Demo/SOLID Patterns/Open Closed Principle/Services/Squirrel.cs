using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class SquirrelWOCP : AnimalWOCP
{
    public override string MakeSound()
    {
        return "squeak";
    }

    public string SquirrelLegCount(AnimalWOCP a)
    {
        return "2";
    }

    public override string LegCount()
    {
        return "2";
    }
}

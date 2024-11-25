using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class MouseWOCP : AnimalWOCP
{
    public override string MakeSound()
    {
        return "squeak";
    }

    public string MouseLegCount(AnimalWOCP a)
    {
        return "4";
    }

    public override string LegCount()
    {
        return "4";
    }
}

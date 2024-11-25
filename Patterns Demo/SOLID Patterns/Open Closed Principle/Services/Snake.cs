using Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

public class SnakeWOCP : AnimalWOCP
{
    public override string MakeSound()
    {
        return "hiss";
    }

    public string SnakeLegCount(AnimalWOCP a)
    {
        return "0";
    }

    public override string LegCount()
    {
        return "0";
    }
}

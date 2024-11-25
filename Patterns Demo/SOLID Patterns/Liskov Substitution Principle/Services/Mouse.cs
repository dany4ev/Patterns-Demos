
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public class Mouse : Animal
{
    public override string MakeSound()
    {
        return "squeak";
    }

    public string MouseLegCount(Animal a)
    {
        return "4";
    }

    public override string LegCount()
    {
        return "4";
    }
}


using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public class Lion : Animal
{
    public override string MakeSound()
    {
        return "roar";
    }

    public string LionLegCount(Animal a)
    {
        return "4";
    }

    public override string LegCount()
    {
        return "4";
    }
}

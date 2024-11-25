
using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public class Pigeon : Animal
{
    public override string MakeSound()
    {
        return "huurr";
    }

    public string PigeonLegCount(Animal a)
    {
        return "2";
    }

    public override string LegCount()
    {
        return "2";
    }
}
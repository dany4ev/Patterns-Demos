using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public class Squirrel : Animal
{
    public override string MakeSound()
    {
        return "squeak";
    }

    public string SquirrelLegCount(Animal a)
    {
        return "2";
    }

    public override string LegCount()
    {
        return "2";
    }
}

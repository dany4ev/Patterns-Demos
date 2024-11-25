using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public class Snake : Animal
{
    public override string MakeSound()
    {
        return "hiss";
    }

    public string SnakeLegCount(Animal a)
    {
        return "0";
    }

    public override string LegCount()
    {
        return "0";
    }
}

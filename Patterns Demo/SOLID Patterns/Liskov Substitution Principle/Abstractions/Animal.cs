namespace Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

public abstract class Animal
{
    public virtual string MakeSound()
    {
        return "";
    }

    public string Name
    {
        get;
        set;
    }

    public Animal()
    {
    }

    public Animal(string name)
    {
        this.Name = name;
    }

    public void AnimalSound(List<Animal> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            Log(a[i].MakeSound());
        }
    }

    public virtual string LegCount()
    {
        return "0";
    }

    public void Log(object objValue)
    {
        Console.WriteLine(objValue);
    }
}
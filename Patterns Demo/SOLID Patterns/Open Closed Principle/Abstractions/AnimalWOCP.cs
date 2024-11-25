namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Abstractions;

// Class after applying OCP
public abstract class AnimalWOCP
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

    public AnimalWOCP()
    {
    }

    public AnimalWOCP(string name)
    {
        this.Name = name;
    }

    public void AnimalSound(List<AnimalWOCP> a)
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
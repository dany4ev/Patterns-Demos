namespace Patterns_Demo.SOLID_Patterns.Open_Closed_Principle.Services;

// Class violating OCP
public class AnimalVOCP
{
    public string Name
    {
        get;
        set;
    }

    public AnimalVOCP()
    {
    }

    public AnimalVOCP(string name)
    {
        this.Name = name;
    }

    public void AnimalSound(List<AnimalVOCP> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i].Name == "lion")
                Log("roar");
            if (a[i].Name == "mouse")
                Log("squeak");
            if (a[i].Name == "snake")
                Log("hiss");
        }
    }

    private void Log(object objValue)
    {
        Console.WriteLine(objValue);
    }
}

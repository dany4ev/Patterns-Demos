namespace Patterns_Demo.SOLID_Patterns.Single_Responsiblity_Principle.Services;

// Class violating SRP

public class AnimalVSRP
{
    private string _name;
    public AnimalVSRP(string name)
    {
        _name = name;
    }

    public string GetAnimalName()
    {
        return _name;
    }

    public void SaveAnimal(AnimalVSRP a)
    {
        _name = a.GetAnimalName();
    }
}

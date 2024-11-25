namespace Patterns_Demo.SOLID_Patterns.Single_Responsiblity_Principle.Services;

// Class after applying SRP
public class AnimalWSRP
{
    public string _name;
    public AnimalWSRP(string name)
    {
        _name = name;
    }

    public string GetAnimalName()
    {
        return new AnimalDB().GetAnimal(new AnimalWSRP("Fox"));
    }
}

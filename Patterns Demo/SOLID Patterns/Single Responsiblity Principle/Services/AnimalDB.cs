namespace Patterns_Demo.SOLID_Patterns.Single_Responsiblity_Principle.Services;

// Class after applying SRP
public class AnimalDB
{
    public string GetAnimal(AnimalWSRP a)
    {
        return a._name;
    }

    public void SaveAnimal(AnimalWSRP a)
    {
        a._name = GetAnimal(a);
    }
}

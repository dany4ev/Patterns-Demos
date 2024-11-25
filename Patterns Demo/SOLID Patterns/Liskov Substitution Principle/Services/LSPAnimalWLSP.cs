using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

namespace Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;

// Class after applying LSP
public class LSPAnimalWLSP : Animal
{
    public void AnimalLegCount(List<Animal> a)
    {
        for (int i = 0; i <= a.Count; i++)
        {
            a[i].LegCount();
        }
    }
}
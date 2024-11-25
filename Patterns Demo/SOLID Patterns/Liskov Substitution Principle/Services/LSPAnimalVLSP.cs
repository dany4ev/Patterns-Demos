using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

namespace Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;

//3. Class violating LSP
public class LSPAnimalVLSP : Animal
{
    public void AnimalLegCount(List<Animal> a)
    {
        for (int i = 0; i <= a.Count; i++)
        {
            if (a[i].GetType() == new Lion().GetType())
                base.Log(new Lion().LionLegCount(a[i]));
            if (a[i].GetType() == new Mouse().GetType())
                base.Log(new Mouse().MouseLegCount(a[i]));
            if (a[i].GetType() == new Snake().GetType())
                base.Log(new Snake().SnakeLegCount(a[i]));
            if (a[i].GetType() == new Pigeon().GetType())
                base.Log(new Pigeon().PigeonLegCount(a[i]));
        }
    }
}

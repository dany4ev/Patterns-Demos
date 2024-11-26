using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class NullPerson : Person
{
    public override string Name
    {
        get
        {
            return "";
        }
    }

    public override Person GetPerson()
    {
        return new NullPerson();
    }
}

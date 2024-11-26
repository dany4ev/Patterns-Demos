using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class Student : Person
{
    public override string Name
    {
        get
        {
            return "Student Object";
        }
    }

    public override Person GetPerson()
    {
        return new Employee();
    }
}

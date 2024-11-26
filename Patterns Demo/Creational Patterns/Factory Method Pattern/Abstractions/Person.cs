namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

public abstract class Person
{
    public virtual string Name
    {
        get
        {
            return "";
        }
    }

    public abstract Person GetPerson();
}

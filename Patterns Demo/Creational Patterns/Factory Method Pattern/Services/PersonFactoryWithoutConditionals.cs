using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Models;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public static class PersonFactoryWithoutConditionals
{
    private static readonly Dictionary<EnumPerson, Action> persons =
        new()
        {
            { EnumPerson.Person, () => new Person2() }, 
            { EnumPerson.Employee, () => new Employee2() }, 
            { EnumPerson.Manager, () => new Manager2() }, 
            { EnumPerson.NullPerson, () => new NullPerson2() } 
        };

    public static Action CreatePerson<T>(EnumPerson typeName) where T : class, new()
    {
        var action = persons[typeName];

        return action;
    }
}

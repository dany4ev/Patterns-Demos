using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public static class PersonFactory
{
    public static Person GetPerson(string type)
    {
        Person? instance;
        
        switch (type)
        {
            case "Employee":
                instance = new Employee();
                break;
            case "Student":
                instance = new Student();
                break;
            case "Manager":
                instance = new Manager();
                break;
            default:
                instance = new NullPerson();
                break;
        }

        return instance;
    }
}

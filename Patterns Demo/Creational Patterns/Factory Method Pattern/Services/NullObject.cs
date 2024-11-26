using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class NullObject : IM
{
    public void DoStuff()
    {
        // Do nothing in case of null
        // This will avoid exceptions in case the object was null
        // the instance will be returned and method will be called without any logic
    }
}
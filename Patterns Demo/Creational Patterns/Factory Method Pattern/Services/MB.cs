using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class MB : IM
{
    public void DoStuff()
    {
        Console.WriteLine("Method A Class");
    }
}

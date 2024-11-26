using Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Services;

public class Strategy1 : IStrategy
{
    public void DoSomething()
    {
        Console.WriteLine("Execute strategy 1");
    }
}

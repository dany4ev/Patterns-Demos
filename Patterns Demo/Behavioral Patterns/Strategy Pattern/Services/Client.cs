using Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Services;

public class Client
{
    public IStrategy2? Strategy
    {
        get;
        set;
    }

    public void CallAlgorithm()
    {
        if (Strategy is not null)
            Console.WriteLine(Strategy.Algorithm());
    }
}

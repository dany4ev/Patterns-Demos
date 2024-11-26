using Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Services;

public class Context(IStrategy strategy)
{
    private readonly IStrategy strategy = strategy;

    public void ExecuteTheStrategy()
    {
        this.strategy.DoSomething();
    }
}

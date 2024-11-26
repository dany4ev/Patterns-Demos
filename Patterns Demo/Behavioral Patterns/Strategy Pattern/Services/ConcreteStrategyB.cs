using Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Strategy_Pattern.Services;

public class ConcreteStrategyB : IStrategy2
{
    public string Algorithm()
    {
        return "Concrete Strategy B";
    }
}

using Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Services;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        var sub = subject as Subject;

        if (sub is not null)
        {
            if (sub.State == 0 || sub.State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
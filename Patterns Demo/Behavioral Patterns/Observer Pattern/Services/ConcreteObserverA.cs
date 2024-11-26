using Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Services;

// Concrete Observers react to the updates issued by the Subject they had
// been attached to.
public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        var sub = subject as Subject;

        if (sub is not null)
        {
            if (sub.State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}

namespace Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Abstractions;

public interface IObserver
{
    // Receive update from subject
    void Update(ISubject subject);
}

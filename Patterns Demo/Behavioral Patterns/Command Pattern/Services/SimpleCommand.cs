using Patterns_Demo.Behavioral_Patterns.Command_Pattern.Abstractions;

namespace Patterns_Demo.Behavioral_Patterns.Command_Pattern.Services;

// Some commands can implement simple operations on their own.
public class SimpleCommand(string payload) : ICommand
{
    private readonly string _payload = payload;

    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
    }
}
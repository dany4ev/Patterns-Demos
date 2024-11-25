namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// 4. Class violating ISP
public class CircleVISP : ICircleVISP
{
    public void DrawCircle()
    {
        Console.WriteLine($"{nameof(CircleVISP)}, DrawCircle() method called.");
    }
}
namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// 4. Class violating ISP
public class TriangleVISP : ITriangleVISP
{
    public void DrawTriangle()
    {
        Console.WriteLine($"{nameof(TriangleVISP)}, DrawTriangle() method called.");
    }
}
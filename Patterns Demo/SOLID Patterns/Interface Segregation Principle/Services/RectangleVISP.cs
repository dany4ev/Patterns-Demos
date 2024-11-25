namespace Patterns_Demo.SOLID_Pattern_Example.Interface_Segregation_Principle.Services;

// 4. Class violating ISP
public class RectangleVISP : IRectangleVISP
{
    public void DrawRectangle()
    {
        Console.WriteLine($"{nameof(RectangleVISP)}, DrawRectangle() method called.");
    }
}

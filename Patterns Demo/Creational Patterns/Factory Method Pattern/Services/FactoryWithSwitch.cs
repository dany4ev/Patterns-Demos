namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class FactoryWithSwitch
{
    public static void FactoryMethod(string type)
    {
        switch (type.ToUpper())
        {
            case "A":
                MethodA();
                break;
            case "B":
                MethodB();
                break;
            default:
                break;
        }
    }

    private static void MethodA()
    {
        Console.WriteLine("Method A");
    }

    private static void MethodB()
    {
        Console.WriteLine("Method B");
    }
}

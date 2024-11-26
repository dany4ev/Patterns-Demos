using Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Services;

public class ConcreteAlgorithmB : AlgorithmBase
{
    public override void Step1()
    {
        Console.WriteLine("Algorithm B, Step 1");
    }

    public override void Step2()
    {
        Console.WriteLine("Algorithm B, Step 2");
    }

    public override void Step3()
    {
        Console.WriteLine("Algorithm B, Step 3");
    }
}
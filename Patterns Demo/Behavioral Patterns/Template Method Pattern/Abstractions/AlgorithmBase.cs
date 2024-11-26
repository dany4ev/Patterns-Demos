namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

public abstract class AlgorithmBase
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    public abstract void Step1();
    public abstract void Step2();
    public abstract void Step3();
}
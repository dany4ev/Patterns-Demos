namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

public abstract class Etl
{
    protected abstract void Extract();
    protected abstract void Transform();
    protected abstract void Load();
    public void Execute()
    {
        Extract();
        Transform();
        Load();
    }
}
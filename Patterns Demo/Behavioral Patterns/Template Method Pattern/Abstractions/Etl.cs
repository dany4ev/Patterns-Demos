namespace Patterns_Demo.Behavioral_Patterns.Template_Method_Pattern.Interfaces;

public abstract class Etl
{
    public abstract void Extract();
    public abstract void Transform();
    public abstract void Load();
    public void Execute()
    {
        Extract();
        Transform();
        Load();
    }
}
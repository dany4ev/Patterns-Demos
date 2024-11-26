namespace Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Services;

public class TrainSignal
{
    public Action? TrainsAComing;

    public void HereComesATrain()
    {
        // theres a ton of logic in here
        if (TrainsAComing is not null) 
            TrainsAComing();
    }
}

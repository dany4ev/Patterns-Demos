namespace Patterns_Demo.Behavioral_Patterns.Observer_Pattern.Services;

public class Car
{
    public Car(TrainSignal trainSignal)
    {
        trainSignal.TrainsAComing += StopTheCar;
    }

    void StopTheCar()
    {
        Console.WriteLine("Screeetch");
    }
}

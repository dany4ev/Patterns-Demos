namespace Patterns_Demo.Creational_Patterns.Singleton_Pattern.Services;

public class Logger
{
    private Logger()
    {
    }

    private StreamWriter outStream;
    private int logNumber = 0;

    // This is how we are lazy load the singleton instance here
    private static Logger? theInstance;

    public static Logger TheInstance
    {
        get
        {
            if (theInstance == null)
                theInstance = new Logger();
            return theInstance;
        }
    }

    // This is how we are eager loading the singleton instance here
    /*
    private static Logger theInstance = new Logger();
    
    public static Logger TheInstance
    {
        get
        {
            return theInstance;
        }
    }*/

    public void InitializeLogging()
    {
        outStream = new StreamWriter("myLog.txt");
    }

    public void ShutdownLogging()
    {
        outStream.Close();
    }

    public void LogMessage(string message)
    {
        outStream.WriteLine((logNumber++) + ": " + message);
    }
}

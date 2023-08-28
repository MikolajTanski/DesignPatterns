namespace Singleton;

public class Configuration
{
    private static Configuration _instance = null;
    private static object obj = new object();
    
    public string StringProp { get; set; }
    public int IntProp { get; set; }

    private Configuration()
    {
        
    }
    
    public static Configuration GetInstance()
    {
        lock (obj)
        {
            if (_instance == null)
                _instance = new Configuration();
        }
        
        return _instance;
    }
}

namespace Yarp.ReverseProxy.Utilities;

public class ConcurrencyCounterFactory : IConcurrencyCounterFactory
{
    public static readonly IConcurrencyCounterFactory Shared = new ConcurrencyCounterFactory();

    public IConcurrencyCounter CreateCounter(string uid)
    {
        return new AtomicCounter();
    }
}

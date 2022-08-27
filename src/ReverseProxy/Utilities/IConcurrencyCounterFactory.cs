namespace Yarp.ReverseProxy.Utilities;

public interface IConcurrencyCounterFactory
{
    IConcurrencyCounter CreateCounter(string uid);
}

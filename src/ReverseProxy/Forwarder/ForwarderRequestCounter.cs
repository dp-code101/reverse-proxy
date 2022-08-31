using Yarp.ReverseProxy.Model;

namespace Yarp.ReverseProxy.Forwarder;

internal sealed class ForwarderRequestCounter : IForwarderRequestCounter
{
    public void Increment(ClusterState cluster, DestinationState destination)
    {
        cluster.ConcurrencyCounter.Increment();
        destination.ConcurrencyCounter.Increment();
    }

    public void Decrement(DestinationState destination, ClusterState cluster)
    {
        destination.ConcurrencyCounter.Decrement();
        cluster.ConcurrencyCounter.Decrement();
    }
}

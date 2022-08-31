using Yarp.ReverseProxy.Model;

namespace Yarp.ReverseProxy.Forwarder;

public interface IForwarderRequestCounter
{
    /// <summary>
    /// Increments concurrency counter for cluster and destination before forwarding of request
    /// </summary>
    void Increment(ClusterState cluster, DestinationState destination);

    /// <summary>
    /// Decrements concurrency counter for cluster and destination when forwarding of request is completed
    /// </summary>
    void Decrement(DestinationState destination, ClusterState cluster);
}

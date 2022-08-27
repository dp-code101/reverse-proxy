namespace Yarp.ReverseProxy.Utilities;

public interface IConcurrencyCounter
{
    /// <summary>
    /// Gets the current value of the counter.
    /// </summary>
    int Value { get; set; }

    /// <summary>
    /// Atomically increments the counter value by 1.
    /// </summary>
    int Increment();

    /// <summary>
    /// Atomically decrements the counter value by 1.
    /// </summary>
    int Decrement();

    /// <summary>
    /// Atomically resets the counter value to 0.
    /// </summary>
    void Reset();
}

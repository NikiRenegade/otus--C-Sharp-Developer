namespace HW4_InProcessCommunication;

public class PlinqSumCalculator : ISumCalculator
{
    public string Name { get; }

    public PlinqSumCalculator(string name)
    {
        Name = name;
    }
    public long Sum(long[] numbers)
    {
        return numbers.AsParallel().Sum();
    }
}
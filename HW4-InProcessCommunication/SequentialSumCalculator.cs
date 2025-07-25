namespace HW4_InProcessCommunication;

public class SequentialSumCalculator : ISumCalculator
{
    public SequentialSumCalculator(string name)
    {
        Name = name;
    }
    
    public string Name { get;}
    public long Sum(long[] numbers)
    {
        return numbers.Sum();
    }
}
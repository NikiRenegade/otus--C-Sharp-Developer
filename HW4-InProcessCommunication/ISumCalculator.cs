using System.Runtime.InteropServices.JavaScript;

namespace HW4_InProcessCommunication;

public interface ISumCalculator
{
    string Name { get; }
    public long Sum(long[] numbers); 
}
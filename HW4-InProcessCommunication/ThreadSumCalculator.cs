namespace HW4_InProcessCommunication;

public class ThreadSumCalculator : ISumCalculator
{
    public ThreadSumCalculator(string name)
    {
        Name = name;
    }
    
    public string Name { get;}
    public long Sum(long[] numbers)
    {
        int cores = Environment.ProcessorCount;
        long chunkSize = numbers.Length / cores;
        var threads = new List<Thread>(cores);
        long total = 0;
        object lockObj = new();

        for (int i = 0; i < cores; i++)
        {
            int start = (int)(i * chunkSize);
            int end = (i == cores - 1) ? numbers.Length : (int)(start + chunkSize);

            Thread t = new(() =>
            {
                long localSum = 0;
                for (int num = start; num < end; num++)
                {
                    localSum += numbers[num];
                }
                lock (lockObj) { total += localSum; }
            });

            threads.Add(t);
            t.Start();
        }

        foreach (Thread t in threads) t.Join();
        return total;
    }
}
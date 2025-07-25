using System.Diagnostics;

namespace HW4_InProcessCommunication;

class Program
{
    static void Main(string[] args)
    {
        int[] arrayElementCount = [10000000, 100000000, 1000000000];
        //int[] arrayElementCount = [10, 15, 20];
        long[][] arrays = new long[3][];
        arrays[0]= new long[arrayElementCount[0]];
        arrays[1]= new long[arrayElementCount[1]];
        arrays[2]= new long[arrayElementCount[2]];
        Random random = new Random();
        
        foreach (long[] t in arrays)
        {
            for (int j = 0; j < t.Length; j++)
            {
                t[j] = random.Next(100);
            }
        }
        
        ISumCalculator[] sumCalculators = [new SequentialSumCalculator("Синхронный калькулятор"),
            new ThreadSumCalculator("Потоковый калькултор"),
            new PlinqSumCalculator("PLINQ калькулятор")
        ];
        foreach (ISumCalculator sumCalculator in sumCalculators)
        {
            sumCalculator.Sum(new long[] { 1, 2, 3, 4 });
            Console.WriteLine($"Используется {sumCalculator.Name}");
            TimeMeter timeMeter = new TimeMeter();
            Console.WriteLine(timeMeter.MeasureTimeSumCalculator(arrays, sumCalculator));
        }
    }
}
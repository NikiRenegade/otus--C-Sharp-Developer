using System.Diagnostics;

namespace HW4_InProcessCommunication;

public class TimeMeter
{

    public string MeasureTimeSumCalculator(long[][] arrays, ISumCalculator sumCalculator)
    {
        string result = "";
        foreach (long[] numbers in arrays)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var resSum = sumCalculator.Sum(numbers);
            stopwatch.Stop();
            result += $"Количество элементов: {numbers.Length}, Время: {stopwatch.ElapsedMilliseconds} ms," +
                      $" Количество тиков: {stopwatch.ElapsedTicks}," +
                      $" Первая цифра/Первые 3 цифры количества тиков: {stopwatch.ElapsedTicks.ToString().Substring(0,3)} " +
                                                                        $"/ {stopwatch.ElapsedTicks.ToString().Length}," +
                      $"  Результат: {resSum} \n";
        }
        return result;
    }
}
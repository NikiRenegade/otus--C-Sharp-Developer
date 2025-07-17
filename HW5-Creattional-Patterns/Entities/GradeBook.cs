using System.Runtime.InteropServices.JavaScript;

namespace HW5_Creattional_Patterns.Entities;
/// <summary>
/// Зачетная книжка
/// </summary>
public class GradeBook
{
    /// <summary>
    /// Номер зачетной книжки
    /// </summary>
    public int Number { get; set; }
    /// <summary>
    /// Средний балл в данной зачетной книжке
    /// </summary>
    public double AverageScore { get; set; }

    /// <summary>
    /// Конструктор принимающий номер зачетной книжки и средний балл
    /// </summary>
    /// <param name="number"></param>
    /// <param name="averageScore"></param>
    public GradeBook(int number, double averageScore)
    {
        Number = number;
        AverageScore = averageScore;
    }

}
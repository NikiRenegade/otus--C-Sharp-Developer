using System.Runtime.InteropServices.JavaScript;

namespace HW5_Creattional_Patterns.Entities;

public class GradeBook
{
    public int Number { get; set; }
    public double AverageScore { get; set; }

    public GradeBook(int number, double averageScore)
    {
        Number = number;
        AverageScore = averageScore;
    }

}
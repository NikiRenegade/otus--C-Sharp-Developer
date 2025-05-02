namespace HW5_Creattional_Patterns;
using HW5_Creattional_Patterns.Entities;
class Program
{
    static void Main(string[] args)
    {
        GradeBook gradeBook = new GradeBook(45674324, 4.2);
        Student student = new Student(firstName: "Иван", lastName: "Иванов", 33,
            "0402 674324", "РФ", 6576356, "МГУ", gradeBook);
        Student myCloneStudent = student.MyClone();
        myCloneStudent.FirstName = "Петр";
        myCloneStudent.LastName = "Петров";
        myCloneStudent.GradeBook.AverageScore = 4.5;
        object cloneStudent = myCloneStudent.Clone();
        Student CastingCloneStudent = (Student)cloneStudent;
        CastingCloneStudent.FirstName = "Сидор";
        CastingCloneStudent.LastName = "Сидоров";
        CastingCloneStudent.GradeBook.AverageScore = 3.9;
        Console.WriteLine($"Оригинал - {student.FirstName} {student.LastName}" +
                          $" {student.GradeBook.AverageScore}");

        Console.WriteLine($"Клон IMyCloneable - {myCloneStudent.FirstName} {myCloneStudent.LastName}" +
                          $" {myCloneStudent.GradeBook.AverageScore}");

        Console.WriteLine($"Клон ICloneable - {CastingCloneStudent.FirstName} {CastingCloneStudent.LastName}" +
                          $" {CastingCloneStudent.GradeBook.AverageScore}");



    }
}
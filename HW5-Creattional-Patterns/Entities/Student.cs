namespace HW5_Creattional_Patterns.Entities;

/// <summary>
/// Класс студента, наследующийся от класса Citizen
/// </summary>
public class Student : Citizen, IMyCloneable<Student>, ICloneable
{
    /// <summary>
    /// Номер студенчиского билета
    /// </summary>
    public int StudentTicketNumber { get; set; }

    /// <summary>
    /// Наименование Университета
    /// </summary>
    public string UniversityName { get; set; }

    /// <summary>
    /// Информация зачетной книжки
    /// </summary>
    public GradeBook GradeBook { get; set; }

    /// <summary>
    /// Конструктор принимающий все 7 параметров
    /// (3 класса Person которые передаются в коструктор Person
    /// 2 класса Citizen которые передаются в коструктор Citizen
    /// и 2 обробатываются в конструкторе Student
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="age"></param>
    /// <param name="passportNumber"></param>
    /// <param name="citizenship"></param>
    /// <param name="studentTicketNumber"></param>
    /// <param name="universityName"></param>
    /// <param name="gradeBook"></param>
    public Student(string firstName, string lastName, int age, string passportNumber, string citizenship,
        int studentTicketNumber, string universityName, GradeBook gradeBook)
        : base(firstName, lastName, age, passportNumber, citizenship)
    {
        StudentTicketNumber = studentTicketNumber;
        UniversityName = universityName;
        GradeBook = gradeBook;
    }

    /// <summary>
    /// Метод IMyCloneable
    /// </summary>
    /// <returns>Student</returns>
    public Student MyClone()
    {
        return new Student(FirstName, LastName, Age, PassportNumber, Citizenship, StudentTicketNumber, UniversityName,
            GradeBook);
    }

    /// <summary>
    /// Метод ICloneable
    /// </summary>
    /// <returns>object</returns>
    public object Clone()
    {
        return MyClone();
    }
}
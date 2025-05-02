namespace HW5_Creattional_Patterns.Entities;
/// <summary>
/// Класс гражданина, наследующийся от класса Person
/// </summary>
public class Citizen: Person, IMyCloneable<Citizen>, ICloneable
{
    /// <summary>
    /// Серия и номер паспорта
    /// </summary>
    public string PassportNumber { get; set; }
    /// <summary>
    /// Гражданство
    /// </summary>
    public string Citizenship { get; set; }
    /// <summary>
    /// Конструктор принимающий все 5 параметров
    /// (3 класса Person которые передаются в коструктор Person)
    /// и 2 обробатываются в конструкторе Citizen
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="age"></param>
    /// <param name="passportNumber"></param>
    /// <param name="citizenship"></param>
    public Citizen(string firstName, string lastName, int age, string passportNumber, string citizenship)
        : base(firstName, lastName, age)
    {
        PassportNumber = passportNumber;
        Citizenship = citizenship;
    }
    /// <summary>
    /// Метод IMyCloneable
    /// </summary>
    /// <returns>Citizen</returns>
    public Citizen MyClone()
    {
        return new Citizen(FirstName, LastName, Age, PassportNumber, Citizenship);
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
namespace HW5_Creattional_Patterns.Entities;

/// <summary>
/// Класс описывает базового человека с трема полями: Имя, Фамилия, Возраст
/// </summary>
public class Person: IMyCloneable<Person>, ICloneable
{
    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Возраст
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Конструктор принимающий все три параметра
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="age"></param>
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    /// <summary>
    /// Метод IMyCloneable
    /// </summary>
    /// <returns>Person</returns>
    public virtual Person MyClone()
    {
        return new Person(FirstName, LastName, Age);
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
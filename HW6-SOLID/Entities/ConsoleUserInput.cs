namespace HW6_SOLID;
/// <summary>
/// Получатель пользовательской информации через консоль
/// </summary>
public class ConsoleUserInput : IUserInput
{
    /// <summary>
    /// Получение введенного в консоль ответа от пользователя
    /// </summary>
    /// <returns>Ответ пользователя</returns>
    public string GetUserResponse()
    {
        return Console.ReadLine();
    }
}
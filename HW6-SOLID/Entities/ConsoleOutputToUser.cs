namespace HW6_SOLID;
/// <summary>
/// Отправитель пользовательской информации через консоль
/// </summary>
public class ConsoleOutputToUser : IOutputToUser
{
    /// <summary>
    /// Отправка сообщения пользователю через консоль
    /// </summary>
    /// <param name="message">Сообщение пользователю</param>
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }
}
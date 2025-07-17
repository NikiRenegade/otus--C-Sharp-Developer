namespace HW6_SOLID;
/// <summary>
/// Отправитель пользовательской информации
/// </summary>
public interface IOutputToUser
{
    /// <summary>
    /// Отправка сообщения пользователю
    /// </summary>
    /// <param name="message">Сообщение пользователю</param>
    void WriteMessage(string message);
}
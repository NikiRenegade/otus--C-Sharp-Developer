namespace HW6_SOLID;
/// <summary>
/// Получатель пользовательской информации
/// </summary>
public interface IUserInput
{
    /// <summary>
    /// Получение ответа от пользователя
    /// </summary>
    /// <returns>Ответ пользователя</returns>
    string GetUserResponse();
}
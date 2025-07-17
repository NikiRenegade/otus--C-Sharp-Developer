namespace HW6_SOLID;
/// <summary>
/// Валидатор корректности данных
/// </summary>
public interface IValidator
{
    /// <summary>
    /// Проверка корректности данных
    /// </summary>
    /// <param name="input">Данные для проверки</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>Результат проверки</returns>
    bool Validate(string input, out string errorMessage);
}
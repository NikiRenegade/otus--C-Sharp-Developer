namespace HW6_SOLID;
/// <summary>
/// Валидатор проверки значения на целое число
/// </summary>
public class IntegerValidator: IValidator
{
    /// <summary>
    /// Проверка значения на целое число
    /// </summary>
    /// <param name="input">Данные для проверки</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>Результат проверки</returns>
    public virtual bool Validate(string input, out string errorMessage)
    {
        if (int.TryParse(input, out _))
        {
            errorMessage = "";
            return true;
        }
        errorMessage = "Ошибка! Необходимо ввести целое число.";
        return false;
    }
}
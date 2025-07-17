namespace HW6_SOLID;
/// <summary>
/// Валидатор проверки числа в заданном диапозоне
/// </summary>
public class RangeValidator: IntegerValidator
{
    private int min;
    private int max;

    public RangeValidator(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
    /// <summary>
    /// Проверка значения на целое число + проверка на нахождение числа в заданном диапозоне
    /// </summary>
    /// <param name="input">Данные для проверки</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>Результат проверки</returns>
    public override bool Validate(string input, out string errorMessage)
    {
        if (!base.Validate(input, out errorMessage))
        {
            return false;
        }
        int parsed = Convert.ToInt32(input);

        if (parsed >= min && parsed <= max)
        {
            errorMessage = "";
            return true;
        }
        errorMessage = $"Ошибка! Необходимо ввести число от {min} до {max}.";
        return false;
    }
}
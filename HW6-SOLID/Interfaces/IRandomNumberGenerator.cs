namespace HW6_SOLID;
/// <summary>
/// Генератор случайных чисел
/// </summary>
public interface IRandomNumberGenerator
{
    /// <summary>
    /// Генерация случайного числа в заданном диапозоне
    /// </summary>
    /// <param name="min">Минимальное число для генерации</param>
    /// <param name="max">Максимальное число для генерации</param>
    /// <returns>Сгенерированное число</returns>
    int Generate(int min, int max);
}
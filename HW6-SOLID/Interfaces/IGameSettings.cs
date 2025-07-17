namespace HW6_SOLID;
/// <summary>
/// Настройки игры
/// </summary>
public interface IGameSettings
{
    /// <summary>
    /// Минимальное число
    /// </summary>
    int Min { get; }
    /// <summary>
    /// Максимальное число
    /// </summary>
    int Max { get; }
    /// <summary>
    /// Максимальное количество попыток
    /// </summary>
    int MaxAttempts { get; }
}
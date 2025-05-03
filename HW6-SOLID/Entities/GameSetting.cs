namespace HW6_SOLID;
public class GameSetting: IGameSettings
{
    public int Min { get; }
    public int Max { get; }
    public int MaxAttempts { get; }
    public GameSetting(int min, int max, int maxAttempts)
    {
        Min = min;
        Max = max;
        MaxAttempts = maxAttempts;
    }
}
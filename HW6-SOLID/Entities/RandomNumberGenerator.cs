namespace HW6_SOLID;

public class RandomNumberGenerator: IRandomNumberGenerator
{
    public int Generate(int min, int max)
    {
        return new Random().Next(min, max);
    }
}
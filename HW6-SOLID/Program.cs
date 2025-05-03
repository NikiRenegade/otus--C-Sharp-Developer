namespace HW6_SOLID;

class Program
{
    static void Main(string[] args)
    {
        IGameSettings gameSettings = new GameSetting(1, 10, 4);
        IUserInput userInput = new ConsoleUserInput();
        IOutputToUser outputToUser = new ConsoleOutputToUser();
        IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        IValidator validator = new RangeValidator(gameSettings.Min, gameSettings.Max);
        IGame game = new GameGuessNumber(gameSettings, userInput, outputToUser, randomNumberGenerator, validator);
        game.Run();
    }
}
namespace HW6_SOLID;
/// <summary>
/// Игра угадай число
/// </summary>
public class GameGuessNumber : IGame
{
    private IGameSettings _gameSettings;
    private IUserInput _userInput;
    private IOutputToUser _outputToUser;
    private IRandomNumberGenerator _randomNumberGenerator;
    private IValidator _validator;

    public GameGuessNumber(IGameSettings gameSettings, IUserInput userInput, IOutputToUser outputToUser,
        IRandomNumberGenerator randomNumberGenerator, IValidator validator)
    {
        _gameSettings = gameSettings;
        _userInput = userInput;
        _outputToUser = outputToUser;
        _randomNumberGenerator = randomNumberGenerator;
        _validator = validator;
    }

    public void Run()
    {
        int attempt = 0;
        int generationNumber = _randomNumberGenerator.Generate(_gameSettings.Min, _gameSettings.Max);
        bool isSuccess = false;
        _outputToUser.WriteMessage($"Угадайте число от {_gameSettings.Min} до {_gameSettings.Max}.");
        while (attempt <= _gameSettings.MaxAttempts)
        {
            string input = _userInput.GetUserResponse();
            string errorMessage;
            if (!_validator.Validate(input, out errorMessage))
            {
                _outputToUser.WriteMessage(errorMessage);
                continue;
            }
            attempt++;
            int userNumber = int.Parse(input);
            if (userNumber == generationNumber)
            {
                isSuccess = true;
                break;
            }
            if (userNumber > generationNumber)
            {
                _outputToUser.WriteMessage("Ваше число больше загаданного.");
            }
            else if (userNumber < generationNumber)
            {
                _outputToUser.WriteMessage("Ваше число меньше загаданного.");
            }
        }

        if (isSuccess)
        {
            _outputToUser.WriteMessage($"Поздравляю вы победили! Вы угадали число {generationNumber} за попытки {attempt}.");
        }
        else
        {
            _outputToUser.WriteMessage($"К сожалению вы проиграли! Правильный ответ: {generationNumber}.");
        }

    }

}
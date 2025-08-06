using System.Linq.Expressions;
using hw8_Delegate;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Возвращение max элемента коллекции");
		List<Person> people = new List<Person>
		{
			new Person("Alice", 1.68f),
			new Person("Bob", 2.02f),
			new Person("Charlie", 1.85f)
		};
		Person person = people.GetMax(p => p.Height);
		Console.WriteLine($"Самый высокий человек - {person.Name}");

		Console.WriteLine("\n--------------------------------\n");
		Console.WriteLine("Поиск файлов:");
		FileSearcher fileSearcher = new FileSearcher();
		fileSearcher.FileFound += FileSearcher_FileFound;
		fileSearcher.Search("../../../Files");
	}
	public static void FileSearcher_FileFound(object sender, FileArgs e)
	{
		Console.WriteLine($"Найден файл: {e.FileName}\nПродолжить поиск (y/n)?");
		e.IsCancel = Console.ReadLine() == "y" ? false : true;
	}
}
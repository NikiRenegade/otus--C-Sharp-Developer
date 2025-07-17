using System.Diagnostics;
using System.Net.Mime;

namespace HW3_Parallelism;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Введите путь к папке");
        //"../../../Files"
        GetCountSpaceesInFiles(Console.ReadLine());
    }

    static void GetCountSpaceesInFiles(string? path)
    {
        if (!Directory.Exists(path))
        {
            Console.WriteLine("Данной папки не существует");
            return;
        }
        string[] files = Directory.GetFiles(path, "*.txt");
        if (files.Length == 0)
        {
            Console.WriteLine("В данном каталоге нет файлов для прочтения");
            return;
        }
        List<Task<int>> tasks = new List<Task<int>>();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < files.Length; i++)
        {
            int index = i;
            tasks.Add(Task.Run(() =>
            {
                using (StreamReader reader = new StreamReader(files[index]))
                {
                    return reader.ReadToEnd().Count(x=> x == ' ');
                }
            }));
        }
        Task.WaitAll(tasks.ToArray());
        sw.Stop();
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"Количество пробелов в {i + 1} файле: {tasks[i].Result}");
        }
        Console.WriteLine($"Время выполнеия {sw.ElapsedMilliseconds} ms.");
    }
}
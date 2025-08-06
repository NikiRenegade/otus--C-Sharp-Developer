using System;

namespace hw8_Delegate;

public class FileSearcher
{
	public event EventHandler<FileArgs> FileFound;

	public void Search(string path)
	{
		if (!Directory.Exists(path))
		{
			Console.WriteLine("Данной папки не существует");
			return;
		}
		var files = Directory.GetFiles(path);
		if (files.Length == 0)
		{
			Console.WriteLine("В данном каталоге нет файлов для прочтения");
			return;
		}
		foreach (var file in files)
		{
			var fileArgs = new FileArgs(file);
			FileFound?.Invoke(this, fileArgs);
			if (fileArgs.IsCancel) break;
		}
		Console.WriteLine("Поиск завершен.");
	}

}

using System.Collections.Generic;
using System.Diagnostics;

namespace HW7_Reflection;

public static class Program
{
	private static readonly string AssemblyPath = "../../../../HW7-Reflection_ClassLibrary/bin/Debug/net9.0/HW7-Reflection_ClassLibrary.dll";
	private static readonly string ClassName = "HW7_Reflection_ClassLibrary.F";
	private static readonly string ManyObjectsFilePath = "../../../ManyObjects";
	private static readonly string OneObjectFilePath = "../../../OneObject";

	private static readonly int CountObjects = 100000;
	public static void Main(string[] args)
	{
		var assembly = System.Reflection.Assembly.LoadFrom(AssemblyPath);
		var type = assembly.GetType(ClassName);
		var oneInstance = Activator.CreateInstance(type);
		oneInstance = type.GetMethod("Get")?.Invoke(null, null);

		List<object> instances = new List<object>();
		for (int i = 0; i < CountObjects; i++)
		{
			var instance = Activator.CreateInstance(type);
			instances.Add(type.GetMethod("Get")?.Invoke(null, null));
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		CsvSerializer.SerializeManyObjectsToFile(instances, ManyObjectsFilePath + ".csv");
		stopwatch.Stop();
		Console.WriteLine($"CSV Сериализация: {Environment.NewLine}" +
		$"	Время - {stopwatch.ElapsedMilliseconds}ms{Environment.NewLine}" +
		$"	Количество тиков - {stopwatch.ElapsedTicks}{Environment.NewLine}" +
		$"	Количество записанных строк - {instances.Count}{Environment.NewLine} " +
		$"	Полный путь до файла - {Path.GetFullPath(ManyObjectsFilePath + ".csv")}{Environment.NewLine} ");


		stopwatch.Restart();
		var deserializedManyInstancesCsv = CsvDeserializer.DeserializeManyObjectsFromFile(ManyObjectsFilePath + ".csv", type);
		stopwatch.Stop();

		Console.WriteLine($"CSV Десериализация: {Environment.NewLine}" +
		$"	Время - {stopwatch.ElapsedMilliseconds}ms{Environment.NewLine}" +
		$"	Количество тиков - {stopwatch.ElapsedTicks}{Environment.NewLine}" +
		$"	Количество полученных строк - {deserializedManyInstancesCsv.Count()}{Environment.NewLine}");


		stopwatch.Restart();
		JsonSerializerHelper.SerializeManyObjectsToFile(instances, ManyObjectsFilePath + ".json");
		stopwatch.Stop();

		Console.WriteLine($"JSON Сериализация: {Environment.NewLine}" +
		$"	Время - {stopwatch.ElapsedMilliseconds}ms{Environment.NewLine}" +
		$"	Количество тиков - {stopwatch.ElapsedTicks}{Environment.NewLine}" +
		$"	Количество записанных строк - {instances.Count}{Environment.NewLine} " +
		$"	Полный путь до файла - {Path.GetFullPath(ManyObjectsFilePath + ".json")}{Environment.NewLine}");


		stopwatch.Restart();
		var deserializedManyInstancesJson = JsonDeserializerHelper.DeserializeManyObjectsFromFile(ManyObjectsFilePath + ".json", type);
		stopwatch.Stop();

		Console.WriteLine($"JSON Десериализация: {Environment.NewLine}" +
		$"	Время - {stopwatch.ElapsedMilliseconds}ms{Environment.NewLine}" +
		$"	Количество тиков - {stopwatch.ElapsedTicks}{Environment.NewLine}" +
		$"	Количество полученных строк - {deserializedManyInstancesJson.Count()}{Environment.NewLine}");
	}
}
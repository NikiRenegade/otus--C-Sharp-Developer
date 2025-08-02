using System;
using System.Reflection;

namespace HW7_Reflection;

public class CsvSerializer
{
	private static string GetHeaders<T>(T obj)
	{
		var fields = obj?.GetType().GetFields();
		List<string> headers = new List<string>();
		foreach (var field in fields)
		{
			headers.Add(field.Name);
		}
		return string.Join(",", headers);
	}

	private static string GetValues<T>(T obj)
	{
		var fields = obj?.GetType().GetFields();

		List<string> values = new List<string>();
		foreach (var field in fields)
		{
			values.Add(field.GetValue(obj)?.ToString());
		}
		return string.Join(",", values);
	}

	public static string SerializeOneObject<T>(T obj)
	{

		return GetHeaders(obj) + Environment.NewLine + GetValues(obj);
	}
	public static string SerializeManyObjects<T>(IEnumerable<T> objects)
	{
		List<string> rows = new List<string> { GetHeaders(objects.FirstOrDefault()) };

		foreach (var obj in objects)
		{
			rows.Add(GetValues(obj));
		}

		return string.Join(Environment.NewLine, rows);
	}
	public static void SerializeManyObjectsToFile<T>(IEnumerable<T> objects, string filePath)
	{
		var csv = SerializeManyObjects(objects);

		File.CreateText(filePath);
		using (var writer = new StreamWriter(filePath))
		{
			writer.WriteLine(csv);
		}
	}


	public static void SerializeOneObjectToFile<T>(T obj, string filePath)
	{
		var csv = SerializeOneObject(obj);

		File.CreateText(filePath);
		using (var writer = new StreamWriter(filePath))
		{
			writer.WriteLine(csv);
		}
	}

}

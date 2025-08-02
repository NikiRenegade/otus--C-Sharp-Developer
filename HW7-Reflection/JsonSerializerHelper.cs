using System;
using System.Text.Json;

namespace HW7_Reflection;

public class JsonSerializerHelper
{
	public static void SerializeManyObjectsToFile<T>(IEnumerable<T> objects, string filePath)
	{
		var json = SerializeManyObjects(objects);
		File.CreateText(filePath);
		using (var writer = new StreamWriter(filePath))
		{
			writer.WriteLine(json);
		}
	}

	public static string SerializeManyObjects<T>(IEnumerable<T> objects)
	{
		return JsonSerializer.Serialize(objects, new JsonSerializerOptions { IncludeFields = true });
	}

}

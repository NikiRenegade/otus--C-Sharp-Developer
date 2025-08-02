using System;
using System.Text.Json;

namespace HW7_Reflection;

public class JsonDeserializerHelper
{
	public static IEnumerable<object> DeserializeManyObjects(string json, Type type)
	{
		var result = JsonSerializer.Deserialize(json, typeof(List<>).MakeGenericType(type), new JsonSerializerOptions { IncludeFields = true });
		return (IEnumerable<object>)result;
	}


	public static IEnumerable<object> DeserializeManyObjectsFromFile(string filePath, Type type)
	{
		var json = File.ReadAllText(filePath);
		return DeserializeManyObjects(json, type);
	}
}

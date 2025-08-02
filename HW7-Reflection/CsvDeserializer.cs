using System;

namespace HW7_Reflection;

public class CsvDeserializer
{
	public static object DeserializeOneObject(string csv, Type type)
	{
		var lines = csv.Split(Environment.NewLine);

		var headers = lines[0].Split(',');
		var values = lines[1].Split(',');

		var obj = Activator.CreateInstance(type);
		for (int i = 0; i < headers.Length; i++)
		{
			var field = obj.GetType().GetField(headers[i]);
			field.SetValue(obj, Convert.ChangeType(values[i], field.FieldType));
		}
		return obj;

	}
	public static IEnumerable<object> DeserializeManyObjects(string csv, Type type)
	{
		var lines = csv.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
		var headers = lines[0].Split(',');

		List<object> objects = new List<object>();

		foreach (var line in lines.Skip(1))
		{
			var values = line.Split(',');
			var obj = Activator.CreateInstance(type);
			for (int j = 0; j < headers.Length; j++)
			{
				var field = obj.GetType().GetField(headers[j]);
				field.SetValue(obj, Convert.ChangeType(values[j], field.FieldType));
			}
			objects.Add(obj);
		}
		return objects;
	}
	public static object DeserializeOneObjectFromFile(string filePath, Type type)
	{
		var csv = File.ReadAllText(filePath);
		return DeserializeOneObject(csv, type);
	}
	public static IEnumerable<object> DeserializeManyObjectsFromFile(string filePath, Type type)
	{
		var csv = File.ReadAllText(filePath);
		return DeserializeManyObjects(csv, type);
	}
}

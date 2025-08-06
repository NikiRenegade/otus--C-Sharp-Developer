using System;
using System.ComponentModel;

namespace hw8_Delegate;

public class Person
{
	public string Name { get; set; }
	public float Height { get; set; }

	public Person(string name, float height)
	{
		Name = name;
		Height = height;
	}

}

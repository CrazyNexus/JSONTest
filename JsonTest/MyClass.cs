//
// MyClass.cs
//
// Created by Thomas Dubiel on 18.12.2016
// Copyright 2016 Thomas Dubiel. All rights reserved.
//
using System;
using Newtonsoft.Json;
using System.Diagnostics;

namespace JsonTest
{
	public class MyClass
	{
		public MyClass()
		{
		}

		public void saveAll()
		{
			var person = new Person { Name = "John", Birthday = new DateTime(1970, 10, 3) };
			var json = JsonConvert.SerializeObject(person);
			Debug.WriteLine("JSON representation of Person: {0}", json);

			var person2 = JsonConvert.DeserializeObject<Person>(json);
			Debug.WriteLine("{0} - {1}", person2.Name, person2.Birthday);
		}
	}
}

public class Person
{
	public string Name { get; set; }
	public DateTime Birthday { get; set; }
}
﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using ProtoBuf;
using ProtoBuf.Meta;

public class TestProtoclBuffer : MonoBehaviour
{
	[ProtoContract]
	public class Person {
		[ProtoMember(1)]
		public int Id {get;set;}
		[ProtoMember(2)]
		public string Name {get;set;}
		[ProtoMember(3)]
		public Address Address {get;set;}
	}
	[ProtoContract]
	public class Address {
		[ProtoMember(1)]
		public string Line1 {get;set;}
		[ProtoMember(2)]
		public string Line2 {get;set;}
	}

	public void Awake()
	{
		this.Run();
	}

	public void Run()
	{
		var person = new Person {
			Id = 12345, Name = "Fred",
			Address = new Address {
				Line1 = "Flat 1",
				Line2 = "The Meadows"
			}
		};


		string path = "person.bin";

		this.Write(person,path);
		this.Read(path);
	}

	public void Write(Person person, string path)
	{
		using (var file = File.Create(path)) {
			Serializer.Serialize(file, person);
		}
	}

	public void Read(string path)
	{
		Person newPerson;
		using (var file = File.OpenRead(path)) {
			newPerson = Serializer.Deserialize<Person>(file);
		}

		Debug.Log("Id:" + newPerson.Id);
		Debug.Log("Name:" + newPerson.Name);
		Debug.Log("Address.Line1:" + newPerson.Address.Line1);
		Debug.Log("Address.Line2:" + newPerson.Address.Line2);
		//Debug.Log("Phone.Number:" + p.Phones.Number);
		//Debug.Log("Phone.Type:" + p.Phones.Type);
	}
}

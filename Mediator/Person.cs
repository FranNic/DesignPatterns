﻿namespace Mediator
{
	public class Person
	{
		public string Name;
		public ChatRoom Room;
		private List<string> chatLog = new List<string>();

		public Person(string name)
		{
			Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
		}
		public void Receive(string sender, string message)
		{
			string s = $"{sender}: '{message}'";
			Console.WriteLine($"[{Name}] {s}");
			chatLog.Add(s);
		}

		public void Say(string message)
		{
			Room.Broadcast(Name, message);
		}

		public void PrivateMessage(string who, string message)
		{
			Room.Message(Name, who, message);
		}
	}
}
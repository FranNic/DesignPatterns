namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class NormalEngine : Engine
	{
		public override void Start() => Console.WriteLine("Normal engine started.");
		public override void Stop() => Console.WriteLine("Normal engine stopped");
	}
}

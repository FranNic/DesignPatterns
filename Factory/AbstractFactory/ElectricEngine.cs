namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ElectricEngine : Engine
	{
		public override void Start() => Console.WriteLine("Electric engine started, can you here the difference?");
		public override void Stop() => Console.WriteLine("Electric engine stopped, can you here the difference?;");
	}
}

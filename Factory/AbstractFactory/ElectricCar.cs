namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ElectricCar : Car
	{
		private readonly Engine engine;

		public ElectricCar(Engine engine)
		{
			this.engine = engine;
		}

		public override void Drive() => Console.WriteLine("Thats really fun and quiet");

		public Engine GetEngine() => this.engine;
	}
}

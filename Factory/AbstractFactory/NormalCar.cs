namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class NormalCar : Car
	{
		private readonly Engine engine;

		public NormalCar(Engine engine)
		{
			this.engine = engine;
		}

		public override void Drive() => Console.WriteLine("Meh... a normal car...");

		public Engine GetEngine() => this.engine;
	}
}

namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class RaceCar : Car
	{
		private readonly Engine engine;

		public RaceCar(Engine engine)
		{
			this.engine = engine;
		}

		public override void Drive() => Console.WriteLine("Wow! That's fast...");

		public Engine GetEngine() => this.engine;
	}
}
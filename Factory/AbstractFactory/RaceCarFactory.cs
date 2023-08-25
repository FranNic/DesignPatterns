namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class RaceCarFactory: CarFactory
	{
		public override Car CreateCar()
		{
			Engine engine = CreateEngine();
			return new RaceCar(engine);
		}

		protected override Engine CreateEngine()
		{
			return new RaceEngine();
		}
	}
}

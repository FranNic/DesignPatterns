namespace Factory.FactoryMethod
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	// Concrete creator
	public class RaceCarFactory : CarFactory
	{
		public override AbstractCar CreateCar()
		{
			return new RaceCar();
		}
	}

}

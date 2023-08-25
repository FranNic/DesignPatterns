namespace Factory.FactoryMethod
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	// Concrete product
	class RaceCar : AbstractCar
	{
		public override void Drive() => Console.WriteLine("Driving a race car at high speed.");
	}
}

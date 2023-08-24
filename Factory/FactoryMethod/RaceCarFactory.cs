namespace Factory.FactoryMethod
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class RaceCarFactory : AbstractCarFactory
	{
		public override ICar CreateCar(double hP) => new RaceCarManager(hP);
	}
}

namespace Factory.FactoryMethod
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	// Concrete Products
	class NormalCar : AbstractCar
	{
		public override void Drive() => Console.WriteLine("Driving a normal car.");
	}

}

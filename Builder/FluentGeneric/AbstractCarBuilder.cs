namespace Builder.FluentGeneric
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public abstract class AbstractCarBuilder
	{
		protected Car car;
		protected AbstractCarBuilder()
		{
			car = new Car();
		}
		public Car Build() => car;
	}
}

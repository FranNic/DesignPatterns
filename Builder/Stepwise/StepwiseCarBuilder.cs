namespace Builder.Stepwise
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection.Metadata.Ecma335;
	using System.Text;
	using System.Threading.Tasks;

	public class StepwiseCarBuilder 
	{
		// This needs to be static so that the Create() method can be called without instantiating the class.
		public static IBuildCarChassis Create()
		{
			return new Impl();
		}

		// Conversely, one can add this to car class to tie the builder to the object being build.
		private class Impl : IBuildCar, IBuildCarBody, IBuildCarEngine, IBuildCarElectronics, IBuildCarChassis
		{
			private Car car = new Car();

			// This exposes the car object to the outside world.
			public Car Build() => car;

			public IBuildCar BuildCarBody()
			{
				this.car.Add("Body");
				return this;
			}

			public IBuildCarEngine BuildChassis()
			{
				this.car.Add("Chassis");
				return this;
			}

			public IBuildCarElectronics BuildEngine()
			{
				this.car.Add("Engine");
				return this;
			}
			public IBuildCarBody BuildElectronics()
			{
				this.car.Add("Electronics");
				return this;
			}
		}
	}
}

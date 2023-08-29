namespace Decorator
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public abstract class BaseDecorator : Car
	{
		protected Car _car;
		protected BaseDecorator(Car car)
		{
			this._car = car;
		}
	}

	public class SportPackage : BaseDecorator
	{
		public SportPackage(Car car) : base(car)
		{
		}

		public override string GetDescription() => $"{this._car.GetDescription()}, Sport Package";

		public override double GetPrice() => this._car.GetPrice() + 10000;
	}

	public class NightPackage : BaseDecorator
	{
		public NightPackage(Car car) : base(car)
		{
		}

		public override string GetDescription() => $"{this._car.GetDescription()}, Night Package";

		public override double GetPrice() => this._car.GetPrice() + 5000;
	}

	public class LeatherSeats : BaseDecorator
	{
		public LeatherSeats(Car car) : base(car)
		{
		}

		public override string GetDescription() => $"{this._car.GetDescription()}, Leather Seats";

		public override double GetPrice() => this._car.GetPrice() + 2000;
	}
}

namespace Decorator
{
	public abstract class Car
	{
		public abstract string GetDescription();
		public abstract double GetPrice();
		public override string ToString() => $"{this.GetDescription()} costs {this.GetPrice()}";
	}

	public class BasicCar : Car
	{
		public override string GetDescription() => "Basic Car";

		public override double GetPrice() => 20000;
	}

}
namespace Bridge
{
	public abstract class Car
	{
		protected IPaitingFactory factory;

		protected Car(IPaitingFactory factory)
		{
			this.factory = factory;
		}

		public abstract string ToString();

		public abstract string Name { get; set; }
	}

	public class RaceCar : Car
	{
		public RaceCar(IPaitingFactory factory) : base(factory)
		{
		}

		public override string Name { get; set; } = "Race Car";

		public override string ToString() => $"Painting a {Name} with {factory.PaintType}";
	}

	public class ElectricCar : Car
	{
		public ElectricCar(IPaitingFactory factory) : base(factory)
		{
		}

		public override string Name { get; set; } = "Electric Car";

		public override string ToString() => $"Painting a {Name} with {factory.PaintType}";
	}
}
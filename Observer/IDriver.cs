namespace Observer
{
	public interface IDriver
	{
		void Update();
	}

	public class Driver : IDriver
	{
		private readonly string name;
		private readonly ICar car;

		public Driver(string name, ICar car)
		{
			this.name = name;
			this.car = car;
			car.AttachDriver(this);
		}

		public void Update()
		{
			Console.WriteLine($"Driver {name} is notified that the car is {car.GetCarState()}");
		}
	}
}
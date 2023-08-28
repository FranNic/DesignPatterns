namespace Adapter
{
	public class Car : IRailroadAdapter
	{
		private readonly IRailroad railroad;
		public Car(IRailroad railroad)
		{
			this.railroad = railroad;
		}

		public Car(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

		public void SetInRailroad() => Console.WriteLine($"Car {this.Name} is now in railroad. {railroad.DriveOnRails()}");

		public override string ToString()
		{
			return $"Car: {this.Name}";
		}
	}
}
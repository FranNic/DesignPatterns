namespace Facade
{
	// SubSystems
	public class Engine
	{
		public void Start()
		{
			System.Console.WriteLine("Engine started");
		}
		public void Stop()
		{
			System.Console.WriteLine("Engine stopped");
		}
	}

	public class DriveSystem
	{
		public void Drive()
		{
			System.Console.WriteLine("Driving");
		}
	}
	
	public class IgnitionSystem
	{
		public void Start()
		{
			System.Console.WriteLine("Ignition started");
		}
		public void Stop()
		{
			System.Console.WriteLine("Ignition stopped");
		}
	}
}
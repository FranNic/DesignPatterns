namespace Facade
{
	// This is the Facade that call the subsystems
	public class Car
	{
		private readonly Engine _engine;
		private readonly DriveSystem _driveSystem;
		private readonly IgnitionSystem _ignitionSystem;

		public Car()
		{
			_engine = new Engine();
			_driveSystem = new DriveSystem();
			_ignitionSystem = new IgnitionSystem();
		}

		public void Start()
		{
			_ignitionSystem.Start();
			_engine.Start();
			_driveSystem.Drive();
		}

		public void Stop()
		{
			_driveSystem.Drive();
			_engine.Stop();
			_ignitionSystem.Stop();
		}
	}
}

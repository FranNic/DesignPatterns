namespace Observer
{
	public class Car : ICar
	{
		private string carState;
		private List<IDriver> drivers = new List<IDriver>();

		public void AttachDriver(IDriver driver) => drivers.Add(driver);

		public void DetachDriver(IDriver driver) => drivers.Remove(driver);

		public string GetCarState() => carState;

		public void SetCarState(string carState)
		{
			this.carState = carState;
			Notify();
		}

		public void Notify()
		{
			foreach (var driver in drivers)
			{
				driver.Update();
			}
		}
	}

	public interface ICar
	{
		void AttachDriver(IDriver driver);

		void DetachDriver(IDriver driver);

		void Notify();

		string GetCarState();

		void SetCarState(string carState);
	}
}
namespace Proxy.Protection_Proxy
{
	using System;

	// Proxy must implement the same interface as the RealSubject
	public class CarProxy : ICar
	{
		private readonly Driver driver;
		private Car car = new Car();
		public CarProxy(Driver driver)
		{
			this.driver = driver;
		}

		public void Drive()
		{
			if (driver.Age >= 16)
				car.Drive();
			else
				Console.WriteLine("Too young to drive");

		}
	}
}
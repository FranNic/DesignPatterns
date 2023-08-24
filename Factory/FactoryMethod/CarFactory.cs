namespace Factory.FactoryMethod
{
	using System.Collections.Generic;

	public class CarFactory
	{
		private readonly Dictionary<CarType, AbstractCarFactory> _factories;

		public CarFactory()
		{
			_factories = new Dictionary<CarType, AbstractCarFactory>()
			{
				{ CarType.Sport, new RaceCarFactory() },
				{ CarType.Normal, new NormalCarFactory() }
			};
		}

		public ICar ExecuteCreation(CarType action, double hp)
		{
			return _factories[action].CreateCar(hp);
		}
	}
}
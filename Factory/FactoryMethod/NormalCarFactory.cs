namespace Factory.FactoryMethod
{
	// Concrete Creators
	public class NormalCarFactory : CarFactory
	{
		public override AbstractCar CreateCar()
		{
			return new NormalCar();
		}
	}
}
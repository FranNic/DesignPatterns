namespace Factory.AbstractFactory
{
	// Abstract Factory
	public abstract class CarFactory
	{
		public abstract Car CreateCar();

		protected abstract Engine CreateEngine();
	}
}
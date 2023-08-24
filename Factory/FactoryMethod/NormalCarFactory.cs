namespace Factory.FactoryMethod
{
	public class NormalCarFactory : AbstractCarFactory
	{
		public override ICar CreateCar(double hP) => new NormalCarManager(hP);
	}
}
namespace Factory.AbstractFactory
{
	public class ElectricCarFactory : CarFactory
	{
		public override Car CreateCar()
		{
			Engine engine = CreateEngine();
			return new ElectricCar(engine);
		}

		protected override Engine CreateEngine()
		{
			return new ElectricEngine();
		}
	}
}
namespace Factory.AbstractFactory
{
	public class NormalCarFactory : CarFactory
	{
		public override Car CreateCar()
		{
			Engine engine = CreateEngine();
			return new NormalCar(engine);
		}

		protected override Engine CreateEngine()
		{
			return new NormalEngine();
		}
	}
}

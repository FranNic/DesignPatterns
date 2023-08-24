namespace Builder.FacetedBuilder
{
	public class CarBodyBuilder : CarBuilderFacade
	{
		public CarBodyBuilder(Car car)
		{
			Car = car;
		}

		public CarBodyBuilder AddBody()
		{
			Car.Add("Body");
			return this;
		}

		public CarBodyBuilder AddWindows()
		{
			Car.Add("Windows");
			return this;
		}
	}
}
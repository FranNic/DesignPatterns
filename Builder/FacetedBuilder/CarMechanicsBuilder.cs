namespace Builder.FacetedBuilder
{
	public class CarMechanicsBuilder : CarBuilderFacade
	{
		public CarMechanicsBuilder(Car car)
		{
			Car = car;
		}

		public CarMechanicsBuilder AddChassis()
		{
			Car.Add("Chassis");
			return this;
		}

		public CarMechanicsBuilder AddEngine()
		{
			Car.Add("Engine");
			return this;
		}
	}
}
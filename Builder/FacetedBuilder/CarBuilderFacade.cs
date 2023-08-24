namespace Builder.FacetedBuilder
{
	public class CarBuilderFacade
	{
		protected Car Car { get; set; }

		public CarBuilderFacade()
		{
			Car = new Car();
		}

		public Car Build() => Car;

		public CarBodyBuilder Body => new CarBodyBuilder(Car);
		public CarMechanicsBuilder Mechanics => new CarMechanicsBuilder(Car);
	}
}
namespace Command
{
	public interface ICommand
	{
		void Execute();
	}

	public class TurnOnHeadlightsCommand : ICommand
	{
		private readonly Car car;

		public TurnOnHeadlightsCommand(Car car)
		{
			this.car = car;
		}

		public void Execute() => car.TurnOnHeadlights();
	}

	public class IncreaseAirConditioningCommand : ICommand
	{
		private readonly Car car;

		public IncreaseAirConditioningCommand(Car car)
		{
			this.car = car;
		}

		public void Execute() => car.IncreaseAirConditioning();
	}

	public class OpenWindowsCommand : ICommand
	{
		private readonly Car car;

		public OpenWindowsCommand(Car car)
		{
			this.car = car;
		}

		public void Execute() => car.OpenWindows();
	}
}
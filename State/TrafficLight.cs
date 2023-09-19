namespace State
{
	public class TrafficLight
	{
		private ITrafficLightState CurrentState { get; set; }

        public TrafficLight()
        {
			CurrentState = new RedLightState();
		
		}
		public void Change()
		{
			CurrentState.ChangeState(this);
		}

		public void ChangeState(ITrafficLightState trafficLightStateToSet)
        {
			CurrentState = trafficLightStateToSet;
			ReportState();
		}

		public void ReportState()
		{
			// write to console the current state of the traffic light with name of class 
			// that implements ITrafficLightState
			Console.WriteLine($"The traffic light is currently {CurrentState.GetType().Name}");
		}
    }
}
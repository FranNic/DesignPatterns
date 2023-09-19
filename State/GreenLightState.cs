namespace State
{
	public class GreenLightState : ITrafficLightState
	{
		public void ChangeState(TrafficLight light) => light.ChangeState(new YellowLightState());
	}
}
namespace State
{
	public class YellowLightState : ITrafficLightState
	{
		public void ChangeState(TrafficLight light) => light.ChangeState(new RedLightState());
	}
}

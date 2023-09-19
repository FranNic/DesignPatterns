namespace State
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class RedLightState : ITrafficLightState
	{
		public void ChangeState(TrafficLight light) => light.ChangeState(new GreenLightState());
	}
}

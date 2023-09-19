namespace State
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public  interface ITrafficLightState
	{
		void ChangeState(TrafficLight light);
	}
}

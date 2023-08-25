namespace Factory.AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class RaceEngine : Engine
	{
		public override void Start() => Console.WriteLine("Race engine started! It makes so much noice!");
		public override void Stop() => Console.WriteLine("Race engine stopped. Now we can talk.");
	}
}

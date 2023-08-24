namespace Factory.FactoryMethod
{
	using System;

	public class RaceCarManager : ICar
	{
		private readonly double _HP;

		public RaceCarManager(double hP) => this._HP = hP;

		public void StartEngine()
		{
			Console.WriteLine("Race Car StartEngine");
		}
	}
}
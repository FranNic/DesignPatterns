namespace Factory.FactoryMethod
{
	using System;

	public class NormalCarManager : ICar
	{
		private readonly double _HP;

		public NormalCarManager(double hP) => this._HP = hP;

		public void StartEngine()
		{
			Console.WriteLine("Normal Car StartEngine");
		}
	}
}
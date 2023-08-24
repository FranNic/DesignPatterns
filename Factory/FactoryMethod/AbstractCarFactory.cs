﻿namespace Factory.FactoryMethod
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public abstract class AbstractCarFactory
	{
		public abstract ICar CreateCar(double hP);
	}
}
namespace Builder.FluentGeneric
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class GenericBodyWindowsBuilder<T> : GenericBodyBuilder<GenericBodyWindowsBuilder<T>> where T : GenericBodyWindowsBuilder<T>
	{
		public T AddWindows()
		{
			car.Add("Windows");
			return (T)this;
		}
	}	

}

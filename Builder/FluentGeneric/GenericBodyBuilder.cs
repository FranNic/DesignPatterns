namespace Builder.FluentGeneric
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class GenericBodyBuilder<T> : GenericBuilder<GenericBodyBuilder<T>> where T : GenericBodyBuilder<T>
	{
		public T AddBody()
		{
			car.Add("Body");
			return (T)this;
		}
	}
}

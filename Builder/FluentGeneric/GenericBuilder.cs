namespace Builder.FluentGeneric
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class GenericBuilder<T> : AbstractCarBuilder where T : GenericBuilder<T>
	{

	}
}

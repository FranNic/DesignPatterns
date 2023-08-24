namespace Builder.FluentGeneric
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	// Director
	// You need to specify the lowest level builder, if not lower methods will not be accessible.
	public class GenericCarBuilderDirector : GenericBodyWindowsBuilder<GenericCarBuilderDirector>
	{
		public static GenericCarBuilderDirector NewCar => new GenericCarBuilderDirector();
}
}

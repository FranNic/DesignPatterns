namespace ChainOfResponsability
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoubleDefenseModifier : CreatureModifier
	{
		public DoubleDefenseModifier(Creature creature) : base(creature)
		{
		}

		public override void Handle()
		{
			Console.WriteLine($"Doubling {Creature.Name}'s defense");
			Creature.Defense *= 2;
			base.Handle();
		}
	}
}

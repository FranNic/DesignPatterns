namespace ChainOfResponsability
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoubleAttackModifier : CreatureModifier
	{
		public DoubleAttackModifier(Creature creature) : base(creature)
		{
		}

		public override void Handle()
		{
			Console.WriteLine($"Doubling {Creature.Name}'s attack");
			Creature.Attack *= 2;
			base.Handle();
		}
	}
}

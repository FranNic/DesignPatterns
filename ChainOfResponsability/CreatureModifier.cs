namespace ChainOfResponsability
{
	public class CreatureModifier
	{
		protected Creature Creature;
		protected CreatureModifier Next;

		public CreatureModifier(Creature creature)
		{
			Creature = creature ?? throw new ArgumentNullException(paramName: nameof(creature));
		}

		public void Add(CreatureModifier cm)
		{
			if (Next is not null)
			{
				Next.Add(cm);
			}
			else
			{
				Next = cm;
			}
		}

		public virtual void Handle() => Next?.Handle();
	}
}
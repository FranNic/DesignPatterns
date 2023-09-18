namespace Visitor
{
	public interface ICar
	{
		void AcceptVisitor(IMaintenanceVisitor visitor);
	}

	public class SUV : ICar
	{
		public void AcceptVisitor(IMaintenanceVisitor visitor) => visitor.Visit(this);
	}

	public class Sedan : ICar
	{
		public void AcceptVisitor(IMaintenanceVisitor visitor) => visitor.Visit(this);
	}

	public class Truck : ICar
	{
		public void AcceptVisitor(IMaintenanceVisitor visitor) => visitor.Visit(this);
	}
}
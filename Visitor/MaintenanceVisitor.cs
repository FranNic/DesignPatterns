namespace Visitor
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IMaintenanceVisitor
	{
		void Visit(SUV suv);
		void Visit(Sedan sedan);
		void Visit(Truck truck);
	}

	public class MaintenanceVisitor : IMaintenanceVisitor
	{
		public void Visit(SUV suv)
		{
			Console.WriteLine("Performing maintenance on SUV");
		}

		public void Visit(Sedan sedan)
		{
			Console.WriteLine("Performing maintenance on Sedan");
		}

		public void Visit(Truck truck)
		{
			Console.WriteLine("Performing maintenance on Truck");
		}
	}
}

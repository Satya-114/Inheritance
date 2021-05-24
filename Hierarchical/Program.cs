using System;

namespace Hierarchical_inheritance
{
	class Teacher
	{

		public void programming()
		{
			Console.WriteLine("Java programming...");
		}

		public void physics()
		{

			Console.WriteLine("Physics...");
		}

		public void chemistry()
		{

			Console.WriteLine("Chemistry...");

		}
	}

	
	class ComputerDepartment : Teacher
	{

		public void learn()
		{
			Console.WriteLine("ComputerDepartment : Learn...");
		}

	}

	
	class ScienceDepartment : Teacher
	{

		public void learn()
		{
			Console.WriteLine("\nScienceDepartment : Learn...");
		}
	}

	
	public class TestHierarchicalInheritance
	{

		public static void Main(String[] args)
		{

			ComputerDepartment cd = new ComputerDepartment();
			cd.learn();
			cd.programming();

			
			ScienceDepartment sd = new ScienceDepartment();
			sd.learn();
			sd.physics();
			sd.chemistry();

		}

	}
}


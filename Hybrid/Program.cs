using System;

namespace Hybrid_inheritance
{
	class GrandFather
	{

		public void land()
		{
			Console.WriteLine("GradFater's land");
		}

	}

	class Father : GrandFather
	{

		public void home()
		{
			Console.WriteLine("Father's home");
		}

		public void Car()
		{
			Console.WriteLine("Father's Car");
		}
	}

	
	class Son : Father
	{

		
		public Son()
		{
			Console.WriteLine("Son...");
		}

		public void mobile()
		{
			Console.WriteLine("Son's mobile");
		}
	}

	class Daughter : Father
	{

		
		public Daughter()
		{
			Console.WriteLine("Daughter...");
		}

		public void purse()
		{
			Console.WriteLine("Daughter's purse");
		}
	}

	
	public class TestHybridInheritance
	{

		public static void Main(String[] args)
		{

			
			Son s = new Son();
			s.land();
			s.Car(); 
			s.home();
			s.mobile();

			
			Daughter d = new Daughter();
			d.land();
			d.Car(); 
			d.home();
			d.purse();

		}

	}

}


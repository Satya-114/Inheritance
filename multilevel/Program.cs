using System;

namespace Multiple_inheritance
{
	class Color
	{
		public void red()
		{

			Console.WriteLine("Green...");
		}
	}

	interface IFlyable
	{
		void fly();
	}

	interface IEatable
	{
		void eat();
	}

	
	class Bird : Color, IFlyable, IEatable
	{
		
		public void fly()
		{
			Console.WriteLine("Bird flying");
		}

		public void eat()
		{
			Console.WriteLine("Bird eats");
		}
		
	}

	
	public class MultipleInheritance
	{

		public static void Main(String[] args)
		{

			Bird b = new Bird();
			
			b.eat();
			b.fly();
			
			b.red();

		}

	}

}
    


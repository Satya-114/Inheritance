using System;

namespace Multilevel_inheritance
{
	public class GrandFather
	{

		public void oldage()
		{

			Console.WriteLine("we are in grandpa class");
		}
	}

	
	class Father : GrandFather
	{

		public void Age()
		{

			Console.WriteLine("we are in father class");
		}
	}

	
	class Baby : Father
	{

		public void newage()
		{
			Console.WriteLine("we are in baby class");
		}

		public void play()
		{
			Console.WriteLine("Baby is Playing");
		}
	}

	
	class TestMultiLevelInheritence
	{

		
		public static void Display()
		{

			
			Baby b = new Baby();

			b.oldage();
			b.Age();
			b.newage();
			b.play();
		}

		
		public static void Main(String[] args)
		{
			Console.WriteLine("Information:");
			Display();

		}

	}

}
    


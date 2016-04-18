using System;

namespace UnderstandingEnumerations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;

			Console.WriteLine("Hello Neyo!");

			//SuperHero myValue = SuperHero.GreenLantern;

			Console.WriteLine("Type in a superhero's name to see his nickname :");
			string userValue = Console.ReadLine();

			SuperHero myValue;

			if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
			{
				switch (myValue)
				{
					case SuperHero.Batman:
						Console.WriteLine("Caped crusader");
						break;
					case SuperHero.Superman:
						Console.WriteLine("Amn of Steel");
						break;
					case SuperHero.GreenLantern:
						Console.WriteLine("Emerald Knight");
						break;
					default:
						break;
				}
			}
			else
			{
				Console.WriteLine("Does not compute");
			}

			Console.ReadLine();
		}
	}

	enum SuperHero
	{
		Batman,
		Superman,
		GreenLantern
	}

}
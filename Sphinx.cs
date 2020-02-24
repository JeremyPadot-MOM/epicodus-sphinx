using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {
		AskRiddle();
		bool isCorrect = true;
		while(isCorrect)
		{
			isCorrect = AskRiddle();
		}
		Console.WriteLine("You lose.");
	}

	static bool AskRiddle()
	{
  string [] riddle = {"Whats big, red, and eats rocks?", "Where are my hands?", "Whats at the end of a rainbow?"};
	string [] answer = {"The big, red, rock eater", "In my pockets", "Pot of gold"};

	Random rnd = new Random();
	int randomIndex = rnd.Next(0,3);
  Console.WriteLine(riddle[randomIndex]);
  string userAnswer = Console.ReadLine();

	 if (userAnswer == answer[randomIndex])
	 {
		return true;
	 }
	 else
	 {
		return false;
	 }

	}
}

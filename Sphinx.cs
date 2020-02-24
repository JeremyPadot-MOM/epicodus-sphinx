using System;

class Sphinx
{
  static void Main()
  {
   Console.WriteLine("Whats big, red, and eats rocks?");
   string userAnswer = Console.ReadLine();
   if (userAnswer == ("The big, red, rock eater"))
   {
       Console.WriteLine("Thats Correct!");
   }
   else 
   {
       Console.WriteLine("Prepair to die! *You are eaten by the Sphinx*");
   }
  }
}
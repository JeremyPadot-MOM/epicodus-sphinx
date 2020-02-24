using System;

class Sphinx
{
  static void Main()
  {
   Console.WriteLine("Whats big, red, and eats rocks?");
   string userAnswer = Console.ReadLine();
   if (userAnswer == ("The big, red, rock eater"))
   {
       Console.WriteLine("Where are my hands?");
       string userAnswer2 = Console.ReadLine();
       if (userAnswer2 == ("In my pockets"))
       {
    Console.WriteLine("Whats at the end of a rainbow?");
           string userAnswer3 = Console.ReadLine();
           if (userAnswer3 == ("Pot of gold"))
           {
               Console.WriteLine("Thats correct! You dont have to die today");
           }
           else
           {
               Console.WriteLine("Prepare to die! *You are eaten by the Sphinx*");
           }
       }
       else
       {
       Console.WriteLine("Prepare to die! *You are eaten by the Sphinx*");
       }
   }
   else 
   {
       Console.WriteLine("Prepare to die! *You are eaten by the Sphinx*");
   }
  }
}
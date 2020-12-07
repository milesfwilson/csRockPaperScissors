using System;
using System.Collections.Generic;

namespace csRockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {

      List<string> options = new List<string>();
      options.Add("Rock");
      options.Add("Paper");
      options.Add("Scissors");

      bool running = true;
      System.Console.WriteLine(@"Rock, Paper, Scissors!
Enter 1, 2, or 3");

      Random randomizer = new Random();
      int playerScore = 0;
      int computerScore = 0;
      int round = 0;
      while (running && (round < 5))
      {

        int randomNumber = randomizer.Next(0, 3);
        string userInput = Console.ReadLine();
        switch (userInput)
        {
          case "1":
            System.Console.WriteLine($"You Selected {options[0]}, the computer selected {options[randomNumber]}");
            if (randomNumber == 0)
            {
              System.Console.WriteLine("You Tied!");
            }
            else if (randomNumber == 1)
            {
              System.Console.WriteLine("You Lose!");
              computerScore++;

            }
            else
            {
              System.Console.WriteLine("You Win!");
              playerScore++;
            }
            round++;
            System.Console.WriteLine($@"
            Round: {round}/5
            You: {playerScore}, Computer: {computerScore}
            Ready, shoot! 
            1, 2, or 3");
            break;
          case "2":
            System.Console.WriteLine($"You Selected {options[1]}, the computer selected {options[randomNumber]}");
            if (randomNumber == 0)
            {
              System.Console.WriteLine("You Win!");
              playerScore++;

            }
            else if (randomNumber == 1)
            {
              System.Console.WriteLine("You Tied!");

            }
            else
            {
              System.Console.WriteLine("You Lose!");
              playerScore++;
            }
            round++;
            System.Console.WriteLine($@"
            Round: {round}/5
            You: {playerScore}, Computer: {computerScore}
            Ready, shoot! 
            1, 2, or 3");
            break;
          case "3":
            System.Console.WriteLine($"You Selected {options[2]}, the computer selected {options[randomNumber]}");
            if (randomNumber == 0)
            {
              System.Console.WriteLine("You Lose!");
              computerScore++;

            }
            else if (randomNumber == 1)
            {
              System.Console.WriteLine("You Win!");
              playerScore++;
            }
            else
            {
              System.Console.WriteLine("You Tied!");

            }
            round++;
            System.Console.WriteLine($@"
            Round: {round}/5
            You: {playerScore}, Computer: {computerScore}
            Ready, shoot! 
            1, 2, or 3");
            break;
          case "e":
            running = false;
            break;
          default:

            break;

        }
        if (computerScore > playerScore && (round == 5))
        {
          System.Console.WriteLine("You lose the game!");
          System.Console.WriteLine("Play again? Y/N");
          switch (Console.ReadLine())
          {
            case "Y":
              playerScore = 0;
              computerScore = 0;
              round = 0;
              running = true;
              break;
            case "N":
              running = false;
              break;
            default:
              System.Console.WriteLine("Please enter a Y/N");
              break;
          }
        }
        else if (playerScore > computerScore && (round == 5))
        {
          System.Console.WriteLine("You win the game!");
          System.Console.WriteLine("Play again? Y/N");
          switch (Console.ReadLine())
          {
            case "Y":
              playerScore = 0;
              computerScore = 0;
              round = 0;
              running = true;
              System.Console.WriteLine(@"Rock, Paper, Scissors!
Enter 1, 2, or 3");
              break;
            case "N":
              running = false;
              break;
            default:
              System.Console.WriteLine("Please enter a Y/N");
              break;
          }
        }
        else if (playerScore == computerScore && (round == 5))
        {
          System.Console.WriteLine("You Tied!");
          System.Console.WriteLine("Play again? Y/N");
          string response = Console.ReadLine();
          switch (response)
          {
            case "Y":
              playerScore = 0;
              computerScore = 0;
              round = 0;
              running = true;
              System.Console.WriteLine(@"Rock, Paper, Scissors!
Enter 1, 2, or 3");
              break;
            case "N":
              running = false;
              break;
            default:
              System.Console.WriteLine("Please enter a Y/N");
              break;
          }
        }



      }

    }
  }
}

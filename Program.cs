namespace ConsoleApp
{

  static class Globals
  {
    public static int p1Score;
    public static int p2Score;
  }

  class Program
  {
    static void Main()
    {
      Start();
      static void Start()
      {
        Console.WriteLine($"Name The Game: ");
        var gameName = Console.ReadLine();
        Console.WriteLine($"Nice name choice! Now what is player one's name?");
        var p1Name = Console.ReadLine();
        Console.WriteLine($"Okay {p1Name}, who is your opponent today?");
        var p2Name = Console.ReadLine();
        Console.WriteLine($"Okay {p1Name} and {p2Name}, are you ready to play a game of {gameName}? Y/N");
        var startGame = Console.ReadLine().ToUpper();
        if (startGame == "Y")
        {
          RollSixDice();
        }
        else
        {
          Console.WriteLine($"Really? You even named your game! {gameName} was a waste... Thanks.");
        }
      }
      static void RollSixDice()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int die2 = rnd.Next(1, 7);
        int die3 = rnd.Next(1, 7);
        int die4 = rnd.Next(1, 7);
        int die5 = rnd.Next(1, 7);
        int die6 = rnd.Next(1, 7);
        int[] totals = { die1, die2, die3, die4, die5, die6 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.Write(i + " ");
        }
        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }

        Console.WriteLine($"\r\nHow many dice are left?");

        var afterSix = Convert.ToInt32(Console.ReadLine());

        if (afterSix == 5)
        {
          RollFiveDice();
        }
        else if (afterSix == 4)
        {
          RollFourDice();
        }
        else if (afterSix == 3)
        {
          RollThreeDice();
        }
        else if (afterSix == 2)
        {
          RollTwoDice();
        }
        else if (afterSix == 0)
        {
          Console.WriteLine($"Can you roll all six again? Y/N");
          var answer = Console.ReadLine().ToUpper();

          if (answer == "Y")
          {
            RollSixDice();
          }
          else if (answer == "N")
          {
            Console.WriteLine("noted.");
          }
          else
          {
            Console.WriteLine("You found an error from not following directions!!");
          }
        }
        else if (afterSix == 1)
        {
          RollOneDie();
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
          RollSixDice();
        }
      }
      static void RollFiveDice()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int die2 = rnd.Next(1, 7);
        int die3 = rnd.Next(1, 7);
        int die4 = rnd.Next(1, 7);
        int die5 = rnd.Next(1, 7);
        int[] totals = { die1, die2, die3, die4, die5 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.Write(i + " ");
        }

        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }
        Console.WriteLine($"How many dice are left?");

        var afterFive = Convert.ToInt32(Console.ReadLine());

        if (afterFive == 4)
        {
          RollFourDice();
        }
        else if (afterFive == 3)
        {
          RollThreeDice();
        }
        else if (afterFive == 2)
        {
          RollTwoDice();
        }
        else if (afterFive == 0)
        {
          Console.WriteLine($"Can you roll all six again? Y/N");
          var answer = Console.ReadLine().ToUpper();

          if (answer == "Y")
          {
            RollSixDice();
          }
          else if (answer == "N")
          {
            Console.WriteLine("noted.");
          }
          else
          {
            Console.WriteLine("You found an error from not following directions!!");
          }
        }
        else if (afterFive == 1)
        {
          RollOneDie();
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
          RollFiveDice();
        }
      }
      static void RollFourDice()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int die2 = rnd.Next(1, 7);
        int die3 = rnd.Next(1, 7);
        int die4 = rnd.Next(1, 7);
        int[] totals = { die1, die2, die3, die4 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.Write(i + " ");
        }

        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }
        Console.WriteLine($"How many dice are left?");

        var afterFour = Convert.ToInt32(Console.ReadLine());

        if (afterFour == 3)
        {
          RollThreeDice();
        }
        else if (afterFour == 2)
        {
          RollTwoDice();
        }
        else if (afterFour == 0)
        {
          Console.WriteLine($"Can you roll all six again? Y/N");
          var answer = Console.ReadLine().ToUpper();

          if (answer == "Y")
          {
            RollSixDice();
          }
          else if (answer == "N")
          {
            Console.WriteLine("noted.");
          }
          else
          {
            Console.WriteLine("You found an error from not following directions!!");
          }
        }
        else if (afterFour == 1)
        {
          RollOneDie();
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
          RollFourDice();
        }
      }
      static void RollThreeDice()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int die2 = rnd.Next(1, 7);
        int die3 = rnd.Next(1, 7);
        int[] totals = { die1, die2, die3 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.Write(i + " ");
        }

        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }
        Console.WriteLine($"How many dice are left?");

        var afterThree = Convert.ToInt32(Console.ReadLine());

        if (afterThree == 2)
        {
          RollTwoDice();
        }
        else if (afterThree == 0)
        {
          Console.WriteLine($"Can you roll all six again? Y/N");
          var answer = Console.ReadLine().ToUpper();

          if (answer == "Y")
          {
            RollSixDice();
          }
          else if (answer == "N")
          {
            Console.WriteLine("noted.");
          }
          else
          {
            Console.WriteLine("You found an error from not following directions!!");
          }
        }
        else if (afterThree == 1)
        {
          RollOneDie();
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
          RollThreeDice();
        }
      }
      static void RollTwoDice()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int die2 = rnd.Next(1, 7);
        int[] totals = { die1, die2 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.Write(i + " ");
        }
        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }

        Console.WriteLine($"How many dice are left?");

        var afterTwo = Convert.ToInt32(Console.ReadLine());

        if (afterTwo == 1)
        {
          RollOneDie();
        }
        else if (afterTwo == 0)
        {
          Console.WriteLine($"Can you roll all six again? Y/N");
          var answer = Console.ReadLine().ToUpper();

          if (answer == "Y")
          {
            RollSixDice();
          }
          else if (answer == "N")
          {
            Console.WriteLine("noted.");
          }
          else
          {
            Console.WriteLine("You found an error from not following directions!!");
          }
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
          RollTwoDice();
        }
      }
      static void RollOneDie()
      {
        Random rnd = new Random();
        int die1 = rnd.Next(1, 7);
        int[] totals = { die1 };
        Array.Sort(totals);
        foreach (int i in totals)
        {
          Console.WriteLine(i + " ");
        }

        Console.WriteLine($"Who just rolled that? Player 1 or 2?");
        var player = Convert.ToInt32(Console.ReadLine());

        if (player == 1)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p1Score = Globals.p1Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p1Score}");
        }
        else if (player == 2)
        {
          Console.WriteLine("What was your score?");
          var rollScore = Convert.ToInt32(Console.ReadLine());

          Globals.p2Score = Globals.p2Score + rollScore;
          Console.WriteLine($"Nice Roll, your score is now {Globals.p2Score}");
        }

        Console.WriteLine($"Can you roll all 6 again? Y/N");

        var afterOne = Console.ReadLine().ToUpper();

        if (afterOne == "Y")
        {
          RollSixDice();
        }
        else if (afterOne == "N")
        {
          Console.WriteLine("nice job, loser.");
        }
        else
        {
          Console.WriteLine("You found an error from not following directions!!");
        }
      }


      Console.WriteLine($"Roll again? Y/N");

      string playAgain = Console.ReadLine().ToUpper();

      if (playAgain == "Y")
      {
        RollSixDice();
      }
      else if (playAgain == "N")
      {
        Console.WriteLine("Thanks for playing!");
      }
      else
      {
        Console.WriteLine("You found an error from not following directions!!");
      }
    }
  }
}

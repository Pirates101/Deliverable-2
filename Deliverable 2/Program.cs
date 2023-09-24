using System;

class Deliverable2
{
    static void Main()
    {
        string Name = "";
        string agreement;
        int score = 0;
        
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        Name = Console.ReadLine();
        Console.WriteLine("{0} {1}. {2}", "Welcome", Name, "Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        agreement = Console.ReadLine();
        if (agreement == "No" || agreement == "no" || agreement == "NO")
        {
            Console.WriteLine("{0} {1}", "You are a coward", Name);
            return;
        }
        else 
        {
            
            for (int i = 0; i < 5; i++)
            {
                Random ranFlip = new Random();
                int coinflip = ranFlip.Next(0, 2);

                Console.WriteLine("Heads or Tails?");
                string input = Console.ReadLine();
                if ((input == "Heads" && coinflip == 1) || (input == "Tails" && coinflip == 0))
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
        }
        Console.WriteLine("{0} {1}. {2} {3}!", "Thank you", Name, "You got a score of", score);
        return;
    }
}

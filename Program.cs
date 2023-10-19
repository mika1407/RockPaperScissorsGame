using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int playerPoints=0;
        int computerPoints=0;
        String player = "";

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to rock paper scissors game. 3 wins ends the game!");
        Console.ResetColor();

        while (playerPoints != 3 && computerPoints != 3 )
        {         
          Console.WriteLine($"User has {playerPoints} points - Computer has {computerPoints} points");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter ROCK=R, PAPER=P or SCISSORS=S: ");
                Console.ResetColor();
                player = Console.ReadLine() ?? string.Empty;
                player = player.ToUpper();

            if (player == "R" || player == "P" || player == "S")
            {

                int computer = random.Next(0, 3);

                if (computer == 0)
                {
                    Console.WriteLine("Computer chooses rock.");

                    switch (player)
                    {
                        case "R":
                            Console.WriteLine("Tie!");
                            break;
                        case "P":
                            Console.WriteLine("Player wins!");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Computer wins!");
                            computerPoints++;
                            break;
                    }
                }
                else if (computer == 1)
                {
                    Console.WriteLine("Computer chooses paper.");

                    switch (player)
                    {
                        case "P":
                            Console.WriteLine("Tie!");
                            break;
                        case "S":
                            Console.WriteLine("Player wins!");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Computer wins!");
                            computerPoints++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Computer chooses scissors.");

                    switch (player)
                    {
                        case "S":
                            Console.WriteLine("Tie!");
                            break;
                        case "R":
                            Console.WriteLine("Player wins!");
                            playerPoints++;
                            break;
                        default:
                            Console.WriteLine("Computer wins!");
                            computerPoints++;
                            break;
                    }
                }
            }
        }

        if (playerPoints==3)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"User get {playerPoints} points - Computer get {computerPoints} points");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Thanks for playing!");
        Console.ResetColor();

        Console.ReadKey();
    }
}

namespace selfStudy.Game
{
    public class RPS
    {
        readonly string[] OPTIONS = { "", "rock", "paper", "scissors" };
        string player = "";
        string machine = "";
        int number123;
        string playerName = "";

        // the constructor is optional
        //public RPS() { Console.WriteLine("starting new Rock, Paper, Scissors game...."); }

        static string GetPlayerName()
        {
            Console.Write("Player's name: ");
            string? name = Console.ReadLine();
            name = name.Trim();
            return ((name == "") ? "eh" : name);
        }

        static bool StoreMark(int mark)
        {
            // it creates a file with name and mark or adds one more row (if it exists)
            return true;
        }

        static bool CheckForNewRecord()
        {
            // it gets in the file which is the record
            return false;
        }

        public void Run()
        {
            playerName = GetPlayerName().ToUpper();
            while (true)
            {
                Random randomNumber = new Random();

                // gets player option
                while (true)
                {
                    player = "";
                    machine = "";
                    Console.Write("(q to quit) Choose your option (ROCK(1), PAPER(2), OR SCISSORS(3)): ");
                    player = Console.ReadLine().ToLower();
                    if (player == "1" || player == "2" || player == "3" ||
                        player == "rock" || player == "paper" || player == "scissors")
                        break;
                    if (player == "q") return;
                }

                // it gets machine's choice
                number123 = randomNumber.Next(1, 4);
                machine = OPTIONS[number123];

                if (player == "1") player = "rock";
                else if (player == "2") player = "paper";
                else if (player == "3") player = "scissors";
                Console.Write($"  # {playerName} is: {player} - Machine is: {machine}\t==>   ");

                if (player == machine)
                {
                    Console.WriteLine($"We've choosen the same option: {machine}\n");
                    continue;
                }

                switch (player)
                {
                    case "rock":
                        Console.WriteLine((machine == "scissors")
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    case "paper":
                        Console.WriteLine((machine == "rock")
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    case "scissors":
                        Console.WriteLine((machine == "paper")
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\n");
            }
        }

        //public void PrintWinners()
        //{
        //    Console.WriteLine("Winners!!!!!!!!!!!!!!!!!");
        //}
    }
}


namespace selfStudy.Game
{
    public class RPS
    {
        readonly string[] OPTIONS = { "", "rock", "paper", "scissors" };
        string player = "";
        string machine = "";
        int number123 = 0;
        string playerName = "";
        int playerWinsCounter = 0;
        int playerWinsInARowCounter = 0;
        int maxWinsInARow = 0;
        int playerWithoutLosingInARowCounter = 0;
        int maxPlayerWithoutLosingInARow = 0;
        int matchCounter = 0;
        
        // is the constructor need in this case, or
        // the initialization can be done in the class instead of the constructor?
        //public RPS()
        //{
        //    player = "";
        //    machine = "";
        //    number123 = 0;
        //    playerName = "";
        //    playerWinsCounter = 0;
        //    playerWinsInARowCounter = 0;
        //    maxWinsInARow = 0;
        //    playerWithoutLosingInARowCounter = 0;
        //    maxPlayerWithoutLosingInARow = 0;
        //    matchCounter = 0;
        //}

        // the constructor is optional
        //public RPS() { Console.WriteLine("starting new Rock, Paper, Scissors game...."); 

        static string GetPlayerName()
        {
            Console.Write("Player's name: ");
            string? name = Console.ReadLine();
            name = name.Trim();
            return ((name == "") ? "TempPlayer'sName" : name);
        }

        public bool Run()
        {
            Console.WriteLine("\n##### New RPS Game #####");

            Score score = new();
            // using Score gets player's name
            // at the end it will be used again to record data

            playerName = GetPlayerName().ToUpper();
            while (true)
            {
                Random randomNumber = new Random();

                // gets player option
                while (true)
                {
                    player = "";
                    machine = "";
                    Console.Write("(q to quit) Choose your option (ROCK[1], PAPER[2], OR SCISSORS[3]): ");
                    player = Console.ReadLine().ToLower().Trim();
                    if (player == "1" || player == "2" || player == "3" ||
                        player == "rock" || player == "paper" || player == "scissors")
                        break;
                    if (player == "q")
                    {
                        LeaveGame();
                        return true;
                    }
                    // this option is only available for dev purposes
                    // it has to be deleted to run in prod
                    if (player == "z") return false;
                }

                // it gets machine's choice
                number123 = randomNumber.Next(1, 4);
                machine = OPTIONS[number123];

                if (player == "1") player = "rock";
                else if (player == "2") player = "paper";
                else if (player == "3") player = "scissors";

                Console.Write($"  {playerName} is: {player.ToUpper()} VERSUS Machine is: {machine.ToUpper()}\t==>   ");
                matchCounter++;

                if (player == machine)
                {
                    Console.WriteLine($"We've choosen the same option: {machine}\n");
                    UpdateCountersWhenEven();
                    continue;
                }

                bool playersWinner = true;
                switch (player)
                {
                    case "rock":
                        if (machine == "scissors")
                        {
                            UpdateCountersWhenWinning();
                            //playerWinsCounter++;
                            //playerWinsInARowCounter++;
                            //playerWithoutLosingInARowCounter++;
                        } else 
                        {
                            playersWinner = false;
                            UpdateCountersWhenLosing();
                            //if (playerWinsInARowCounter > maxWinsInARow) 
                            //    maxWinsInARow = playerWinsInARowCounter;
                            //if (playerWithoutLosingInARowCounter > maxPlayerWithoutLosingInARow)
                            //    maxPlayerWithoutLosingInARow = playerWithoutLosingInARowCounter;

                            //playerWinsInARowCounter = 0;
                        }

                        Console.WriteLine(playersWinner
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    case "paper":
                        if (machine == "rock")
                        {
                            UpdateCountersWhenWinning();
                        } else
                        {
                            playersWinner = false;
                            UpdateCountersWhenLosing();
                        }

                        Console.WriteLine(playersWinner
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    case "scissors":
                        if (machine == "paper")
                        {
                            UpdateCountersWhenWinning();
                        } else
                        {
                            playersWinner = false;
                            UpdateCountersWhenLosing();
                        }

                        Console.WriteLine(playersWinner
                            ? $"{playerName} has just won!!"
                            : "Machine is the Winner!");
                        break;

                    default:
                        break;
                }
                Console.Write("\n");
            }
        }

        private void UpdateCountersWhenEven()
        {
            if (playerWinsInARowCounter > maxWinsInARow)
                maxWinsInARow = playerWinsInARowCounter;

            playerWithoutLosingInARowCounter++;
            playerWinsInARowCounter = 0;
        }
        private void UpdateCountersWhenWinning()
        {
            playerWinsCounter++;
            playerWinsInARowCounter++;
            playerWithoutLosingInARowCounter++;
        }
        private void UpdateCountersWhenLosing()
        {
            if (playerWinsInARowCounter > maxWinsInARow)
                maxWinsInARow = playerWinsInARowCounter;
            if (playerWithoutLosingInARowCounter > maxPlayerWithoutLosingInARow)
                maxPlayerWithoutLosingInARow = playerWithoutLosingInARowCounter;

            playerWinsInARowCounter = 0;
            playerWithoutLosingInARowCounter = 0;
        }
        private void LeaveGame()
        {
            Console.WriteLine("Leaving game!!");
            Console.WriteLine($"You played {matchCounter} times.");
            Console.WriteLine($"You won {playerWinsCounter} times in total");
            Console.WriteLine($"You won {maxWinsInARow} times in a row");
            Console.WriteLine($"You played {maxPlayerWithoutLosingInARow} times in a row without losing");
            if (playerWinsCounter > 0)
                Console.WriteLine($"{((Convert.ToDouble(playerWinsCounter) / Convert.ToDouble(matchCounter)) * 100):C0}" +
                    $"% in total of victory");
            if (playerWithoutLosingInARowCounter > 0)
                Console.WriteLine($"{((Convert.ToDouble(playerWithoutLosingInARowCounter) / Convert.ToDouble(matchCounter)) * 100):C0}" +
                    $"% playing without losing in a row");

            // comment below only for dev purposes
            // it has to be uncommented for prod environment
            //Environment.Exit(0);
        }

        //public void PrintWinners()
        //{
        //    Console.WriteLine("Winners!!!!!!!!!!!!!!!!!");
        //}
    }
}


namespace selfStudy.Game
{
    public class PlayAGame
    {
        public PlayAGame()
        {
            Console.WriteLine("################### PlayAGame's Constructor");
            RPS newGame = new RPS();
            newGame.Run();
        }


        /*
         * the code below will not execute bkz only one Main in a program
         * looks like the compiler does not even consider this code
         */
        public static void Main()
        {
            Console.WriteLine("################### PlayAGame's Main");
            RPS game = new RPS();
            game.Run();
        }
    }
}

using System;
using System.Linq;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            #region validate arguments
            if (args == null || args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please try again with the following arguments: [playersNumber], [minRangeValue], [maxRangeValue]");
                return;
            }
            else
            {
                int tempArg;
                //if any argument is not a number returns error
                if(args.ToList().Count(a=> int.TryParse(a, out tempArg) == false) > 0 )
                {
                    Console.WriteLine("Invalid arguments, please try again with the following arguments: [playersNumber], [minRangeValue], [maxRangeValue]");
                    return;
                }
            }
            #endregion validate arguments

            GameItem game = new GameItem(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2]));

            game.Play();
        }

//The principle of the game is as follows:
//1. The system chooses a number between[Min; Max] (the mystery number)
//2. The player proposes a number between[Min; Max]
//3. If the player's proposal is not the mystery number, the system tells the player whether:
//a.HI: the mystery number is > the player's guess
//b.LO: the mystery number is < the player's guess
//And the player plays again.
//4. The goal of the game is to discover the mystery number in a minimum of iterations.
//Finally, you are asked to add a multiplayer concept to the game.Think of this request as an opportunity to show us that you can design a solution.
    }
}

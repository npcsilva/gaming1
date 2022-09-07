using System;

namespace HighLow
{
    public class GameItem
    {
        readonly HighLowItem HiLoValue;
        readonly int PlayerCount;

        public GameItem(int playerCount, int min, int max)
        {
            HiLoValue = new HighLowItem(min, max);
            PlayerCount = playerCount;
        }

        public void Play()
        {
            int player = 0;
            int value = 0;
            bool endOfGame = false;
            do
            {
                if (player == PlayerCount)
                {
                    player = 1;
                }
                else
                {
                    player++;
                }

                Console.WriteLine("Player " + player + " enter a value (Limits[" + HiLoValue.MinLimit + " - " + HiLoValue.MaxLimit + "]): ");

                while (int.TryParse(Console.ReadLine(), out value) == false)
                {
                    Console.WriteLine("The value must be an integer");
                }

                endOfGame = this.EvaluatePlay(player, value);
            } while (!endOfGame);
        }

        bool EvaluatePlay(int playerNumber, int value)
        {
            bool result = false;
            string hiLoResult = HiLoValue.CompareToValue(value);

            if (hiLoResult == "Winner!")
            {
                Console.WriteLine(hiLoResult + " Player " + playerNumber);
                result = true;
            }
            else
            {
                Console.WriteLine(hiLoResult);
            }

            return result;
        }

    }
}

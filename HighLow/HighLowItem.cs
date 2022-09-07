using System;

namespace HighLow
{
    public class HighLowItem
    {
        public int Value { get; }
        public int MinLimit { get; }
        public int MaxLimit { get; }

        public HighLowItem(int min, int max)
        {
            Random r = new Random();
            if (min < max)
            {
                Value = r.Next(min, max);
                MinLimit = min;
                MaxLimit = max;
            }
            else
            {
                Value = r.Next(max, min);
                MinLimit = max;
                MaxLimit = min;
            }
        }

        public string CompareToValue(int number)
        {
            if (number == Value)
            {
                return "Winner!";
            }
            if (number < Value)
            {
                return "LO";
            }
            else
            {
                return "HI";
            }
        }
    }
}

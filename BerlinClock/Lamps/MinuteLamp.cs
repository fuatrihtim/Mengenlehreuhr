using System;
using System.Text;

namespace BerlinClock.Lamps
{
    public class MinuteLamp : Lamp
    {
        public StringBuilder Minute { get; set; }

        public string GetMinuteColor(int minute)
        {
            MinuteLamp minuteLamp = new MinuteLamp
            {
                Count = minute % 5,
                Minute = new StringBuilder("OOOO")
            };

            for (int i = 0; i < minuteLamp.Count; i++)
            {
                minuteLamp.Minute[i] = Convert.ToChar(Color.Y.ToString());
            }

            return minuteLamp.Minute.ToString();
        }
    }
}

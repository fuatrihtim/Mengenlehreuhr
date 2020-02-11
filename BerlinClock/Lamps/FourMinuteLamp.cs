using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClock.Lamps
{
    public class FourMinuteLamp : Lamp
    {
        public StringBuilder Minute { get; set; }

        public List<int> RedLampPositions { get; set; }

        public string GetFourMinuteColor(int minute)
        {
            FourMinuteLamp fourMinuteLamp = new FourMinuteLamp
            {
                Count = minute / 5,
                Minute = new StringBuilder("OOOOOOOOOOO"),
                RedLampPositions = new List<int>() { 3, 6, 9 }
            };

            for (int i = 0; i < fourMinuteLamp.Count; i++)
            {
                fourMinuteLamp.Minute[i] = Convert.ToChar(Color.Y.ToString());

                if (fourMinuteLamp.RedLampPositions.Contains(i + 1))
                {
                    fourMinuteLamp.Minute[i] = Convert.ToChar(Color.R.ToString());
                }
            }

            return fourMinuteLamp.Minute.ToString();
        }
    }
}

using System;
using System.Text;

namespace BerlinClock.Lamps
{
    public class FiveHourLamp : Lamp
    {
        public StringBuilder Hour { get; set; }

        public string GetFiveHourColor(int hour)
        {
            FiveHourLamp fiveHourLamp = new FiveHourLamp
            {
                Count = hour / 5,
                Hour = new StringBuilder("OOOO")
            };

            for (int i = 0; i < fiveHourLamp.Count; i++)
            {
                fiveHourLamp.Hour[i] = Convert.ToChar(Color.R.ToString());
            }

            return fiveHourLamp.Hour.ToString();
        }
    }
}

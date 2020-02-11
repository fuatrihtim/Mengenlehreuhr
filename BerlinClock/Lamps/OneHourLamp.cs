using System;
using System.Text;

namespace BerlinClock.Lamps
{
    public class OneHourLamp : Lamp
    {
        public StringBuilder Hour { get; set; }

        public string GetOneHourColor(int hour)
        {
            OneHourLamp oneHourLamp = new OneHourLamp
            {
                Count = hour % 5,
                Hour = new StringBuilder("OOOO")
            };

            for (int i = 0; i < oneHourLamp.Count; i++)
            {
                oneHourLamp.Hour[i] = Convert.ToChar(Color.R.ToString());
            }

            return oneHourLamp.Hour.ToString();
        }
    }
}

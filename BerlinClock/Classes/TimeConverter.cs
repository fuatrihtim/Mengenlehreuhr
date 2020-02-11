using BerlinClock.Lamps;
using System;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            StringBuilder berlinClock = new StringBuilder();
            
            if (IsValidTimeFormat(aTime))
            {
                int.TryParse(aTime.Split(':')[0], out int hour);
                int.TryParse(aTime.Split(':')[1], out int minute);
                int.TryParse(aTime.Split(':')[2], out int second);

                SecondLamp secondLamp = new SecondLamp();
                berlinClock.AppendLine(secondLamp.GetBlinkColor(second));

                FiveHourLamp fiveHourLamp = new FiveHourLamp();
                berlinClock.AppendLine(fiveHourLamp.GetFiveHourColor(hour));

                OneHourLamp oneHourLamp = new OneHourLamp();
                berlinClock.AppendLine(oneHourLamp.GetOneHourColor(hour));

                FourMinuteLamp fourMinuteLamp = new FourMinuteLamp();
                berlinClock.AppendLine(fourMinuteLamp.GetFourMinuteColor(minute));

                MinuteLamp minuteLamp = new MinuteLamp();
                berlinClock.Append(minuteLamp.GetMinuteColor(minute));
            }

            return berlinClock.ToString();
        }

        public bool IsValidTimeFormat(string time)
        {
            TimeSpan outputTime;

            return TimeSpan.TryParse(time, out outputTime);
        }
    }
}

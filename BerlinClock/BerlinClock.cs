using BerlinClock.Lamps;

namespace BerlinClock
{
    public class BerlinClock
    {
        public bool Blink { get; set; }

        public FiveHourLamp FiveHourLamp { get; set; }

        public OneHourLamp OneHourLamp { get; set; }

        public FourMinuteLamp FourMinuteLamp { get; set; }

        public MinuteLamp MinuteLamp { get; set; }
    }
}

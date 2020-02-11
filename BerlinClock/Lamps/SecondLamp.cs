namespace BerlinClock.Lamps
{
    public class SecondLamp
    {
        public string GetBlinkColor(int second)
        {
            if (second % 2 == 0)
            {
                return Color.Y.ToString();
            }

            return Color.O.ToString();
        }
    }
}

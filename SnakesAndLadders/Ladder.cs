namespace SnakesAndLadders
{
    public class Ladder
    {
        public int Bottom { get; }
        public int Top { get; }

        public Ladder(int bottom, int top)
        {
            Bottom = bottom;
            Top = top;
        }

        public int Increase()
        {
            return Top - Bottom;
        }
    }
}
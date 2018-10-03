using System;

namespace SnakesAndLadders
{
    public interface IRollable
    {
        int Roll();
    }

    public class Die : IRollable
    {
        public int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}
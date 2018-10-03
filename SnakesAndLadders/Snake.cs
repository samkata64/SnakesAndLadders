namespace SnakesAndLadders
{
    public class Snake
    {
        public int Head { get; }
        public int Tail { get; }

        public Snake(int head, int tail)
        {
            Head = head;
            Tail = tail;
        }

        public int Reduction()
        {
            return (Head - Tail) * -1;
        }
    }
}
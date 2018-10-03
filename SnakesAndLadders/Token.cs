namespace SnakesAndLadders
{
    public class Token
    {
        private int _location;

        public Token()
        {
            _location = 1;
        }
        
        public int Location()
        {
            return _location;
        }

        public void Move(int spaces)
        {
            _location += spaces;
        }
    }
}
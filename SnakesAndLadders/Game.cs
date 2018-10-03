namespace SnakesAndLadders
{
    public class Game
    {
        private Token _token;

        public void Add(Token token)
        {
            _token = token;
        }

        public void MoveToken(int spaces)
        {
            if (_token.Location() + spaces <= 100)
            {
                _token.Move(spaces);
            }
        }

        public bool IsWon()
        {
            return (_token.Location() == 100);
        }
    }
}
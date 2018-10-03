namespace SnakesAndLadders
{
    public class Game
    {
        private const int FinalSquare = 100;

        private Token _token;

        public void Add(Token token)
        {
            _token = token;
        }

        public void MoveToken(int spaces)
        {
            if (_token.Location() + spaces <= FinalSquare)
            {
                _token.Move(spaces);
            }
        }

        public bool IsWon()
        {
            return (_token.Location() == FinalSquare);
        }
    }
}
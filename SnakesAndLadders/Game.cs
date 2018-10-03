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
            _token.Move(spaces);
        }

        public bool IsWon()
        {
            return true;
        }
    }
}
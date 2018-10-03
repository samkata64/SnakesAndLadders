using System;

namespace SnakesAndLadders
{
    public class Game
    {
        private const int FinalSquare = 100;

        private Token _token;
        private Snake _snake;

        public Game()
        {
            _snake = new Snake(0, 0);
        }

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

            if (_token.Location() == _snake.Head)
            {
                _token.Move(_snake.Reduction());
            }
        }

        public void Add(Snake snake)
        {
            _snake = snake;
        }

        public bool IsWon()
        {
            return (_token.Location() == FinalSquare);
        }
    }
}
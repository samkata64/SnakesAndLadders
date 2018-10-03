using System;

namespace SnakesAndLadders
{
    public class Game
    {
        private const int FinalSquare = 100;

        private Token _token;
        private Snake _snake;
        private Ladder _ladder;

        public Game()
        {
            _snake = new Snake(0, 0);
            _ladder = new Ladder(0, 0);
        }

        public void Add(Token token)
        {
            _token = token;
        }

        public void Add(Ladder ladder)
        {
            _ladder = ladder;
        }

        public void Add(Snake snake)
        {
            _snake = snake;
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
            else if(_token.Location() == _ladder.Bottom)
            {
                _token.Move(_ladder.Increase());
            }
        }

        public bool IsWon()
        {
            return (_token.Location() == FinalSquare);
        } 
    }
}
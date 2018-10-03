# SnakesAndLadders

Kata taken from http://agilekatas.co.uk/katas/snakesandladders-kata

## Prerequisites / Setup

* Visual Studio 2017 Community Edition
* C# (Net Framework 4.7)
* Nunit 3

## Narrative
The following notes are a _stream of consciousness_ !

### Feature 1

There are a number of candidate objects in the description:
1. Player
1. Token
1. Board
1. Game
1. Dice

* After the first test and commits I'm wondering what role the game plays. It's mentioned with interactions. I'll leave it for now and come back to it.
* The game is now used - I see it as the natural place for 'rules' to belong. (I'm listening to the tests)
* The game is always won in the first implementation. Need to triangulate now on stopping the token excedding 100 squares and ensuring the ```game.IsWon() == false```. Done.

## Notes

I'd like to experiment with events on the Snakes and ladders classes - these could "detect" a collision and tell the game to move the token. Overkill here - but could be interesting.

The Snakes and ladders feel quite basic data objects, it would be interesting to explore the interactions. However the tests pass and the trivial code is easy to understand and work with.

I'm not a fan of the Game class and would watch closely how it develops. The snakes and ladders (and dice?) could be passed in the ctor (DI) and the null object dodge for the snake and ladder in the ctor is a smell.

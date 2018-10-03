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
* Player
* Token
* Board
* Game
* Dice

* After the first test and commits I'm wondering what role the game plays. It's mentioned with interactions. I'll leave it for now and come back to it.
* The game is now used - I see it as the natural place for 'rules' to belong. (I'm listening to the tests)
* The game is always won in the firts implementation. Need to triangulate now on stopping the token excedding 100 squares and the ```game.IsWon() == false```.

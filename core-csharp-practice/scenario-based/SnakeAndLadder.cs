using System;
class SnakeAndLadder{
	static void Main(string[] args){
		// players array holds our players' names
		string[] players = InitializeGame();
		
		// Number of players in our game
		int playerCount = players.Length;

		// Initial position of each of the players is 0
		int[] playersPositions = new int[playerCount];

		int playersTurn = 0; // Initially, the first turn will be given to the first player (i.e., 0th player)
		// Game runs until somebody wins
		while(true){
			Console.WriteLine("\tIt is " + players[playersTurn] + "'s turn, press \"p\" to roll the dice");
			string playerInput = Console.ReadLine();
			if(!playerInput.Equals("p")) continue;
			MovePlayer(players, playersPositions, playersTurn);
			if(CheckWin(playersPositions[playersTurn])){
				Console.WriteLine("\t" + players[playersTurn] + " wins");
				break;
			}
			playersTurn = (playersTurn + 1)%playerCount;
			Console.WriteLine();
		}

	}

	static string[] InitializeGame(){
		// Running game start menu to get the number of players:
		Console.WriteLine("\n================ Snake & Ladder ================");
		int playerCount = 0;
		while(true){
			Console.Write("Please enter the number of players (between 2 and 4): ");
			playerCount = int.Parse(Console.ReadLine());
			if(playerCount >= 2 && playerCount <= 4) break;
		}

		// Players' names are stored in the players array
		string[] players = new string[playerCount];
		
		// Getting players' names
		for(int i = 0; i < playerCount; i++){
			Console.Write("Please enter the name of player " + (i+1) + ": ");
			players[i] = Console.ReadLine();
		}

		return players;
	}

	// RollDice method returns an integer between 1 and 6
	static int RollDice(){
		Random rand = new Random();
		int stepsToMove = rand.Next(1, 7);
		return stepsToMove;
	}

	static void MovePlayer(string[] players, int[] playersPositions, int playerNumber){
		// Player rolls the dice
		int stepsToMove = RollDice();
		int playerOldPosition = playersPositions[playerNumber];
		int playerNewPosition = playerOldPosition + stepsToMove;
		int snake = 0, ladder = 0;
		// snakeFlag represents whether the player landed on the snake. Initially we consider the player doesn't land on snake position
		// ladderFlag represents whether the player landed on the ladder. Initially we consider the player doesn't land on the ladder position
		bool snakeFlag = false, ladderFlag = false;

		// If player's new position goes beyond 100, the player stays where he is
		if(playerNewPosition > 100){
			playerNewPosition = playerOldPosition;
		}
		// Otherwise
		else{
			// Checking if there's a snake on the palyer's new position
			snake = IsSnake(playerNewPosition); // snake represent where player would end up
			if(snake != 0){
				snakeFlag = true;
				// Moving player backward
				playerNewPosition = snake;
			}

			// Checking if there's a ladde on the player's new position
			ladder = IsLadder(playerNewPosition); // ladder represent where player would end up
			if(ladder != 0){
				ladderFlag = true;
				// Moving player forward
				playerNewPosition = ladder;
			}
		}
		// Updating player's position
		playersPositions[playerNumber] = playerNewPosition;

		// Showing turn details
		Console.WriteLine("\tTurn Details");
		Console.WriteLine("\tPlayer Name: " + players[playerNumber]);
		Console.WriteLine("\tDice Value: " + stepsToMove);
		if(snakeFlag) Console.WriteLine("\tPlayer moves to position " + snake + " because of the snake");
		if(ladderFlag) Console.WriteLine("\tPlayer moves to position " + ladder + " because of the ladder");
		Console.WriteLine("\tOld position " + playerOldPosition + " --> New Position " + playerNewPosition);
	}


	static bool CheckWin(int playerNewPosition){
		return playerNewPosition == 100;
	}
	
	// IsSnake function returns 0 if there is no snake on the "position" and returns resulting position if there is a snake
	static int IsSnake(int position){
		switch (position){
			case 38:
				return 20;
			case 45:
				return 7;
			case 51:
				return 10;
			case 65:
				return 54;
			case 91:
				return 73;
			case 97:
				return 61;
			default:
				return 0;
		}
	}

	// IsLadder function returns 0 if there is no ladder on the "position" and returns resulting position if there is a ladder
	static int IsLadder(int position){
		switch(position){
			case 5:
				return 58;
			case 14:
				return 49;
			case 42:
				return 60;
			case 53:
				return 72;
			case 64:
				return 83;
			case 75:
				return 94;
			default:
				return 0;
		}
	}
}
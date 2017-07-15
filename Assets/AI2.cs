using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MNode
{
	public int x;
	public int y;
}

public class Move // the score of a move and the corresponding move to that score
{
	public int score; 
	public int x;
	public int y;
}

public class AI2 : MonoBehaviour 
{
	public GameObject xprefab;
	public GameObject oprefab;

	public int[,] gameState = new int[3, 3]; // holds a representation of the board

	void Start () 
	{
		for (int i = 0; i < 3; i++) 
		{
			for (int j = 0; j < 3; j++) 
			{
				gameState [i, j] = 0;
			}
		}
	}

	void Update () 
	{
			if (Input.GetKeyDown ("q") && gameState [0, 0] == 0) {
				Instantiate (xprefab, new Vector3 (-6.8f, -15.5f, 7.68f), Quaternion.identity);
				gameState [0, 0] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("w") && gameState [0, 1] == 0) {
				Instantiate (xprefab, new Vector3 (0f, -15.5f, 7.68f), Quaternion.identity);
				gameState [0, 1] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("e") && gameState [0, 2] == 0) {
				Instantiate (xprefab, new Vector3 (6.8f, -15.5f, 7.68f), Quaternion.identity);
				gameState [0, 2] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("a") && gameState [1, 0] == 0) {
				Instantiate (xprefab, new Vector3 (-6.8f, -15.5f, 0.71f), Quaternion.identity);
				gameState [1, 0] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("s") && gameState [1, 1] == 0) {
				Instantiate (xprefab, new Vector3 (0f, -15.5f, 0.71f), Quaternion.identity);
				gameState [1, 1] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("d") && gameState [1, 2] == 0) {
				Instantiate (xprefab, new Vector3 (6.84f, -15.5f, 0.71f), Quaternion.identity);
				gameState [1, 2] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("z") && gameState [2, 0] == 0) {
				Instantiate (xprefab, new Vector3 (-6.8f, -15.5f, -6.33f), Quaternion.identity);
				gameState [2, 0] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("x") && gameState [2, 1] == 0) {
				Instantiate (xprefab, new Vector3 (0f, -15.5f, -6.33f), Quaternion.identity);
				gameState [2, 1] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
			if (Input.GetKeyDown ("c") && gameState [2, 2] == 0) {
				Instantiate (xprefab, new Vector3 (7.02f, -15.5f, -6.33f), Quaternion.identity);
				gameState [2, 2] = 1; // player is represented by number 1, computer by 2

				Move bestMove = minimax (gameState, 2);
				gameState [bestMove.x, bestMove.y] = 2;
				calculateCoordinates (bestMove.x, bestMove.y);
			}
	}

	List<MNode> listAvailableMoves(int[,] currGameState)
	{
		List<MNode> result = new List<MNode> ();
		for (int i = 0; i < 3; i++) 
		{
			for (int j = 0; j < 3; j++) 
			{
				if (currGameState [i, j] == 0) 
				{
					MNode temp = new MNode();
					temp.x = i;
					temp.y = j;
					result.Add (temp);
				}
			}
		}
		return result;
	}

	public void calculateCoordinates(int x, int z)
	{
		if (x == 0 && z == 0)
		{
			Instantiate (oprefab, new Vector3(-6.8f,-15.5f,7.68f), Quaternion.identity);
		}
		else if (x == 0 && z == 1)
		{
			Instantiate (oprefab, new Vector3(0f,-15.5f,7.68f), Quaternion.identity);
		}    
		else if (x == 0 && z == 2)
		{
			Instantiate (oprefab, new Vector3(6.8f,-15.5f,7.68f), Quaternion.identity);
		}
		else if (x == 1 && z == 0)
		{
			Instantiate (oprefab, new Vector3(-7.03f,-15.5f,0.71f), Quaternion.identity);
		}
		else if (x == 1 && z == 1)
		{
			Instantiate (oprefab, new Vector3(0f,-15.5f,0.71f), Quaternion.identity);
		}
		else if (x == 1 && z == 2)
		{
			Instantiate (oprefab, new Vector3(6.8f,-15.5f,0.71f), Quaternion.identity);
		}
		else if (x == 2 && z == 0)
		{
			Instantiate (oprefab, new Vector3(-6.8f,-15.5f,-6.33f), Quaternion.identity);
		}
		else if (x == 2 && z == 1)
		{
			Instantiate (oprefab, new Vector3(0f,-15.5f,-6.33f), Quaternion.identity);
		}
		else if (x == 2 && z == 2)
		{
			Instantiate (oprefab, new Vector3(6.8f,-15.5f,-6.33f), Quaternion.identity);
		}
	}

	public bool computerWon()
	{
		if (gameState[0,0] == 2 && gameState[1,1] == 2 && gameState[2,2] == 2)
		{
			return true;
		}
		else if (gameState[2,0] == 2 && gameState[1,1] == 2 && gameState[0,2] == 2)
		{
			return true;
		}
		else if (gameState[0,0] == 2 && gameState[0,1] == 2 && gameState[0,2] == 2)
		{
			return true;
		}
		else if (gameState[1,0] == 2 && gameState[1,1] == 2 && gameState[1,2] == 2)
		{
			return true;
		}
		else if (gameState[2,0] == 2 && gameState[2,1] == 2 && gameState[2,2] == 2)
		{
			return true;
		}
		else if (gameState[0,0] == 2 && gameState[1,0] == 2 && gameState[2,0] == 2)
		{
			return true;
		}
		else if (gameState[0,1] == 2 && gameState[1,1] == 2 && gameState[2,1] == 2)
		{
			return true;
		}
		else if (gameState[0,2] == 2 && gameState[1,2] == 2 && gameState[2,2] == 2)
		{
			return true;
		}
		return false;
	}

	public bool playerWon()
	{
		if (gameState[0,0] == 1 && gameState[1,1] == 1 && gameState[2,2] == 1)
		{
			return true;
		}
		else if (gameState[2,0] == 1 && gameState[1,1] == 1 && gameState[0,2] == 1)
		{
			return true;
		}
		else if (gameState[0,0] == 1 && gameState[0,1] == 1 && gameState[0,2] == 1)
		{
			return true;
		}
		else if (gameState[1,0] == 1 && gameState[1,1] == 1 && gameState[1,2] == 1)
		{
			return true;
		}
		else if (gameState[2,0] == 1 && gameState[2,1] == 1 && gameState[2,2] == 1)
		{
			return true;
		}
		else if (gameState[0,0] == 1 && gameState[1,0] == 1 && gameState[2,0] == 1)
		{
			return true;
		}
		else if (gameState[0,1] == 1 && gameState[1,1] == 1 && gameState[2,1] == 1)
		{
			return true;
		}
		else if (gameState[0,2] == 1 && gameState[1,2] == 1 && gameState[2,2] == 1)
		{
			return true;
		}
		return false;
	}


	public Move minimax(int[,] currGameState, int currentPlayer)
	{
			List<MNode> possibleMoves = listAvailableMoves (currGameState);
			Move returnValue = new Move ();

			if (computerWon ()) {
				returnValue.score = 1;
				return returnValue;
			} else if (playerWon ()) {
				returnValue.score = -1;
				return returnValue;
			} else if (possibleMoves.Count == 0) {
				returnValue.score = 0;
				return returnValue;
			}

			if (currentPlayer == 1) {    // since it is player 1, find the min value
				int minimum = int.MaxValue;
				foreach (MNode coordinate in possibleMoves) {
					currGameState [coordinate.x, coordinate.y] = 1;

					Move value = minimax (currGameState, 2);
					if (value.score < minimum) {
						minimum = value.score;
						returnValue.score = minimum;
						returnValue.x = coordinate.x;
						returnValue.y = coordinate.y;
					}
					currGameState [coordinate.x, coordinate.y] = 0;
				}
				return returnValue;
			}
			if (currentPlayer == 2) {    // since it is player 2, find the max value
				int maximum = int.MinValue;
				foreach (MNode coordinate in possibleMoves) {
					currGameState [coordinate.x, coordinate.y] = 2;
				
					Move value = minimax (currGameState, 1);
					if (value.score > maximum) {
						maximum = value.score;
						returnValue.score = maximum;
						returnValue.x = coordinate.x;
						returnValue.y = coordinate.y;
					}
					currGameState [coordinate.x, coordinate.y] = 0;
				}
				return returnValue;
			}
			return returnValue;
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimArray : MonoBehaviour {

	//Right here will be a public transform to place the game objects.
	//Code goes here...
	public Transform OrePos;
	public GameObject Ore;

	//declaring the rows and cols here
	public static int rows = 16;
	public static int cols = 16;

	//Declaring the 2D Array over here
	private int [,] Grid = new int[rows,cols];

	//Reference to the White ore gameobject

	// "i" will represent rows
	// "j" will represent cols

	public int gridX;
	public int gridY;
	public int gridZ;

	void Start(){




	}



	void spawnGrid(){

		//for loops within a for loop
		for (int i = 0; i < rows; i++) {
			//Instantiate the prefab a random location?
			for (int j = 0; j < cols; j++) {
				Grid [rows, cols] = Random.Range(1,17);
				//Instantiate the prefab here too?
				Instantiate(Ore,OrePos);
			}

		}



	}













}

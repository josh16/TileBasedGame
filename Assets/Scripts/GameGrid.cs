using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour {

	//Only can have ONE instance
	public static GameGrid instance;

	//public Transform OreGridPrefab;

	public GameObject OrePrefab;

	//Prefab of the ore
	public GameObject [,] OreTiles ;
	// declaring a size of the map

	public Vector2 m_mapSize;



	// creating an outline so you can see each tile
	[Range(0,1)]
	public float m_outlinePercent;



	void Awake()
	{
		//
		instance = this;
	}

	void Start()
	{
		GenerateMap();
	}


	public void GenerateMap()
	{
		OreTiles = new GameObject[16,16];

		// tiles for the x-axis
		for(int x = 0; x < m_mapSize.x; x++ )
		{
			// tiles for the y-axis
			for (int y = 0; y < m_mapSize.y; y++)
			{
				// position of tile when spawned into the world
				// with the left most edge of tile
				Vector3 m_tilePosition = new Vector3(-m_mapSize.x / 2 + 0.5f + x , -m_mapSize.y / 2 + 0.5f + y, 0);

				//Transform n_Ore = Instantiate (Ore, m_tilePosition);
				// spawning the tile
				//Transform m_newTile = Instantiate(OreGridPrefab, m_tilePosition, Quaternion.Euler(Vector3.zero)) as Transform;

				//new code added
				GameObject go = GameObject.Instantiate(OrePrefab, m_tilePosition, Quaternion.Euler(Vector3.zero)) as GameObject;
				//Debug.Log (OrePrefab.name);

				OreTiles [x, y] = go;

				// creating the outline
				//m_newTile.localScale = Vector3.one * (1 - m_outlinePercent);



			}

		}
		genResources ();



	}


	public void ScanOre(int x, int y)
	{
		//5000 tiles
		//Middle tile
		Debug.Log("ScanOre!!! SEE");
		OreTiles [x, y].GetComponent<TileScript>().setColour();

		//2500 tiles
		//Right tile
		OreTiles [x+1, y].GetComponent<TileScript>().setColour();

		//Left 

		OreTiles [x-1, y].GetComponent<TileScript>().setColour();

		//Top right corner tile

		OreTiles [x+1, y+1].GetComponent<TileScript>().setColour();

		//Bottom Right Corner
	
		OreTiles [x+1, y-1].GetComponent<TileScript>().setColour();


		//Top Left Corner tile

		OreTiles [x-1, y+1].GetComponent<TileScript>().setColour();


		//Bottom Tile
	
		OreTiles [x-1, y-1].GetComponent<TileScript>().setColour();

		//Top Middle Tile
		OreTiles [x, y+1].GetComponent<TileScript>().setColour();

		//Bottom Tile
		OreTiles [x, y-1].GetComponent<TileScript>().setColour();


	}




	public void  genResources()
	{
		int ranGen = Random.Range (6, 9);


			int x;
			int y;

		for(int j = 0; j< ranGen; j++)
		{
			//y = Random.Range (m_mapSize);

			//hardcode
			y = Random.Range(3,14);
			x = Random.Range (3, 14);
			//Debug.Log (OreTiles [x, y].name);

			//5000 tiles
			//Middle tile
			OreTiles [x, y].GetComponent<TileScript> ().score = 5000;
			//OreTiles [x, y].GetComponent<TileScript>().setColour();

			//2500 tiles
			//Right tile
			OreTiles [x+1, y].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x+1, y].GetComponent<TileScript>().setColour();

			//Left 
			OreTiles [x-1, y].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x-1, y].GetComponent<TileScript>().setColour();

			//Top right corner tile
			OreTiles [x+1, y+1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x+1, y+1].GetComponent<TileScript>().setColour();

			//Bottom Right Corner
			OreTiles [x+1, y-1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x+1, y-1].GetComponent<TileScript>().setColour();


			//Top Left Corner tile
			OreTiles [x-1, y+1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x-1, y+1].GetComponent<TileScript>().setColour();


			//Bottom Tile
			OreTiles [x-1, y-1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x-1, y-1].GetComponent<TileScript>().setColour();


			//Top Middle Tile
			OreTiles [x, y+1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x, y+1].GetComponent<TileScript>().setColour();

			//Bottom Tile
			OreTiles [x, y-1].GetComponent<TileScript> ().score = 2500;
			//OreTiles [x, y-1].GetComponent<TileScript>().setColour();



			//1250 Tiles


		


			
		
		
		
		}


	}
}

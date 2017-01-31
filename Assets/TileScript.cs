using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	public int score;





	public void reduceScore()
	{

	}




	public void setColour()
	{
		//Gold Ore
		if (score == 5000) {

			GetComponent<Renderer> ().materials [0].color = Color.yellow;
		}
		//Black Ore
		if(score == 2500)
		{
			
			GetComponent<Renderer> ().materials [0].color = Color.blue;
		}

		//Green Ore
		if(score == 1250)
		{

			GetComponent<Renderer> ().materials [0].color = Color.green;
		}
		//Red Ore
		if(score == 625)
		{

			GetComponent<Renderer> ().materials [0].color = Color.red;
		}



	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	


	private int scans = 6;


	void OnMouseDown()
	{
		GetComponent<TileScript> ().setColour ();
		Scan();
	}




	public void Scan()
	{
		GetComponent<TileScript> ().setColour ();

		//Nested 4 loop that will iteralte through my tile array

		for (int y = 0; y < 16; y++)
		{
			for (int x = 0; x < 16; x++)
			{
				if (gameObject == GameGrid.instance.OreTiles[x,y])
				{
					GameGrid.instance.ScanOre(x, y);
					scans--;
					Debug.Log ("WORK!!!");
					//scansNumText.text = scans.ToString();
					//if (scans <= 0)
					//{
						//messageText.text = "No more scans left, click the scanning icon to switch to mining!";
					//}
				}
			}
		}

	}






//	public ExtractOre()
//	{
//
		//calling function
//	}



}

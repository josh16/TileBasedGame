using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour {

	//This script will change the colour of the gameobject after clicking it


	//bool changeColour = true;
  //bool Scanning = false;

	//Score
	private static int count;
	public Text countText;
	public Text countText2;
	public Text countText3;
	public Text countText4;




	// Use this for initialization
	void Start () {
	
		//Count will start off at Zero.
		count = 0;
		setCountText();
		countText = GameObject.Find("UICanvas").transform.FindChild("WhiteOreUI").GetComponent<Text>();
		countText2=GameObject.Find("UICanvas").transform.FindChild("BrownOreUI ").GetComponent<Text>();
		countText3=GameObject.Find("UICanvas").transform.FindChild("OrangeOreUI").GetComponent<Text>();
		countText3=GameObject.Find("UICanvas").transform.FindChild("GoldOreUI").GetComponent<Text>();
	
		//countText=GetComponent<Text> ();
	}


	void Update(){
		
	}


	void ScanningMode()
	{
		//Scanning = true;
	}





	/*

	//Highlighting the ore to change to colour yellow.
	void OnMouseOver()
	{
		s
		//if (changeColour == true) {
			GetComponent<Renderer> ().materials [0].color = Color.yellow;
		//} 

	}


	//Un-Highlighting the ore to change back to its default colour.
	void OnMouseExit()
	{
		
		GetComponent<Renderer> ().materials [0].color = Color.white;

	}


	*/
	/*i
	//Destroying the White ore(Top layer)
	void OnMouseDown()
	{
		if (tag == "WOre")
			
			count = count + 100;
			Debug.Log (count);
			setCountText (); // Call it here again so it updates everytime the ore is clicked
			Destroy(this.gameObject);

		if (tag == "OrangeOre") 
		{
			count = count + 100;
			Debug.Log (count);
			setCountText (); // Call it here again so it updates everytime the ore is clicked
			//Destroy(this.gameObject);

		}

	}
	*/
	

	void setCountText()
	{
		countText.text = " " + count.ToString();

	}


}

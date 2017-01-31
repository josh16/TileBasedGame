using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeLoc : MonoBehaviour {

	public Vector3[] Positions;


	// Use this for initialization
	void Start () {

		int randomNumber = Random.Range(0, Positions.Length);
		transform.position = Positions [randomNumber];
	}
	

}

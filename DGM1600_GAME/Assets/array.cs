using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour {

	public string [] heros = new string [6];


	// Use this for initialization
	void Start () {
	heros [0] = "batman";
	heros [1] = "batman";
	heros [2] = "wonder woman";
	heros [3] = "green lantern";
	heros [4] = "hawkman";
	heros [5] = "bat girl";
	
	print(heros[0]); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidfun : MonoBehaviour {
	public int laserblast;

	// Use this for initialization
	void Start () {
		Deathstar(laserblast);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Deathstar (int vent){
		print ("Thats no moon thats a space station!");

	if(vent == 1){
			print("porkin's misses the mark!");
		}
	else if (vent == 2){
	 print("red leader misses");
	}

	else{
		print("death star blows uppppppp!!!!!!!");
	}

	}

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreachlist : MonoBehaviour {


	// Use this for initialization
	void Start () {
		List<firstorder> badguys = new List<firstorder>();

		badguys.Add( new firstorder("snoke",1000));
		badguys.Add( new firstorder("general hux",20));
		badguys.Add( new firstorder("kylo ren", 400));
		badguys.Add( new firstorder("captian phasma", 150));

		badguys.Sort();

		foreach(firstorder guy in badguys){
			print(guy.name +" " +guy.power); 

 
	}
	

		
	}
}

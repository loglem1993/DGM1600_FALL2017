using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour {

	public void dostuff(){
			print("Im doing stuff..");
	}

public int AddNumbers(int num1, int num2){
		
		int result = num1 + num2;

		return result; 
	}
	void Start(){
		dostuff();
		int result = AddNumbers(5,11);
		print(result);
	}
	
} 
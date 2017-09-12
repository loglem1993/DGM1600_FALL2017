using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional : MonoBehaviour {

public string stoplight = "Red";

 void Start(){
 	main();

}
void main(){
    if(stoplight == "Red" ){
	print("STOP! The light is Red!");	
	}
	else if (stoplight == "yellow"){
		print ("slow down!");
	}
	else if (stoplight == "green"){
		print ("Green means GO!");
	}
	else if (stoplight == "black"){
		print ("go back");
	}
	
	else{ 
		print ("el broken stupido");
	}
	

}

}
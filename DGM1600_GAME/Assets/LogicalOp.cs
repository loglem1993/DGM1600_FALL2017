using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOp : MonoBehaviour {

	public string luke = "jedi";


	public string vader = "sith";

	public string darkside = "Darth Maul";

	public string lightside = "Obi Wan";


public bool leia = true; 

	// Use this for initialization
	 void Start () {
	// if(luke == "jedi" && vader == "sith" ){
	// 	print("vaders yo nanny!");
	// 	}		
	// 	else if (luke=="jawa" && vader == "sith"){

	// 		print("utini");
	// 		 }
	// 		 else if (luke == "jedi" && vader == "sith"){
	// 			print("I am your father!");
	// 		}
	// 		else{
	// 			print("you shouldnt see this");

	// 		}
	// if(leia){
	// 	print("no,there is another");
	// } 
	// else if(!leia){
	// 	print("Hurray! Now I can Date Luke");
	// }
	// else {
	// 	print("han fired first");
	// }
	if(lightside == "Obi Wan" || darkside == "Jar Jar Binks"){
		print("Meeza Evil Bad Bad Sith Lorda");
	} 
	 else if(lightside == "Boba fett" || darkside == "Darth Maul"){
		 print("As you wish, my master");
	 }
	 else {
		 print("not the younglings"); 
	 }
	 }

	// Update is called once per frame
	void Update () {
		
	}
}

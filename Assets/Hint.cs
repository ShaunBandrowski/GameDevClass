using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hint : MonoBehaviour {


	bool rescue = false;
	bool hintOne = false;
	bool hintTwo = false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance(GameObject.Find("Alien").transform.position,(GameObject.Find("UFO").transform.position));
		float distTwo = Vector3.Distance(GameObject.Find("Drone").transform.position,(GameObject.Find("UFO").transform.position));
		float distThree = Vector3.Distance(GameObject.Find("Crash").transform.position,(GameObject.Find("UFO").transform.position));
		string textBuffer = "";

		if (dist > 250){

			if(hintOne == false && hintTwo == false&&rescue == false){

			textBuffer += "Look for your fallen comrade and any clues that might help you find him!\n\nYou did hear a loud crash coming from the East...";

			}else if(hintOne == true && hintTwo == false){

				textBuffer += "Head North and look for more clues!";

			}

			if(hintTwo == true && dist <680 && rescue == false){

				textBuffer += "Your comrade is somewhere nearby!";

			}else if (hintTwo == true && dist > 680 && rescue == false){

				textBuffer += "Head back near the crashed ship to look for your comrade!";

			}

			if ( distTwo < 300&& rescue == false){

				textBuffer = "The fallen drone is emitting a signal that points North...";
				hintOne = true;

			}

			if(distThree < 460 && rescue == false){

				textBuffer = "This is your comrade's crashed ship!  He must be close...";
				hintTwo = true;
				hintOne = false;

			}

		}else if(dist<250&&rescue==false){

			textBuffer += "You found him! Press [SPACE] to beam him up to your ship!";

			if(Input.GetKeyDown(KeyCode.Space)){
				hintOne = false;
				hintTwo = false;
				rescue = true;

			}
		
		}

		if (rescue == true){

			textBuffer += "Congrats!  You rescued him!";

		}
		GetComponent<Text>().text = textBuffer;  

	}
}

using UnityEngine;
using System.Collections;


public class UFOMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//move forward if I press [W]
		//GetKeyDown = having to press the button over and over 
		//GetKey = will move as long as that button is held down
		if (Input.GetKey ( KeyCode.W ) ) {
			
			//Time.deltaTime is the fraction of a second in between a frame
			//A value that gets bigger with low FPS, but smaller with high FPS
			transform.position += new Vector3 (0f, 0f, 100f) * Time.deltaTime;
		}
		
		//FRAMERATE - DEPENDENT
		//IF I HAVE MORE FPS, I GO FASTER
		
		//FRAMERATE - INDEPENDENT
		//NO MATTER WHAT YOUR FRAMERATE IS, YOU GET THE SAME BEHAVIOR
		//Movement should be framerate independent
		
		//move backward if I press [S]
		if (Input.GetKey ( KeyCode.S ) ) {
			
			//Time.deltaTime is the fraction of a second in between a frame
			//A value that gets bigger with low FPS, but smaller with high FPS
			transform.position += new Vector3 (0f, 0f, -100f) * Time.deltaTime;
		}
		
		//move left if I press [A]
		if (Input.GetKey ( KeyCode.A ) ) {
			
			//Time.deltaTime is the fraction of a second in between a frame
			//A value that gets bigger with low FPS, but smaller with high FPS
			transform.position += new Vector3 (-100f, 0f, 0f) * Time.deltaTime;
		}
		
		//move right if I press [D]
		if (Input.GetKey ( KeyCode.D ) ) {
			
			//Time.deltaTime is the fraction of a second in between a frame
			//A value that gets bigger with low FPS, but smaller with high FPS
			transform.position += new Vector3 (100f, 0f, 0f) * Time.deltaTime;
		}


	
	}
}

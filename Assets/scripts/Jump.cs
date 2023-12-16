using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump:MonoBehaviour
{    // public Vector2 JumpForce;
	// Update is called once per frame
	void Update()
	{
		handleInput();
		// if(Input.GetButtonDown("Fire1"))
		// {// // firstly we add the force to jump then add the audio not opposite
		// //   GetComponent<Rigidbody2D>().AddForce(JumpForce);
		//   GetComponent<AudioSource>().Play();
		// }
	}
	void handleInput()
	{
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0, 0.06f,0);  
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0, -0.06f,0);  
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0.06f, 0,0);  
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-0.06f, 0,0);  
		}
	}
}

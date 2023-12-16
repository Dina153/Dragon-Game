// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DragonKiller : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{ // killer dragon if y > 5.5 m or y < -5.5
		if(transform.position.y > 5.8){
		   SceneManager.LoadScene(0);
		   DragonKillerCount.score = 0;
		   }
		if(transform.position.y < -5.8){
		   SceneManager.LoadScene(0);
		   DragonKillerCount.score = 0;
		   }
		   
	}
	private void OnCollisionEnter2D(Collision2D other) {
		SceneManager.LoadScene(0);
		DragonKillerCount.score = 0;
	}
}

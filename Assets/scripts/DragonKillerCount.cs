using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DragonKillerCount : MonoBehaviour
{
	public static int score = 0;
	public TextMeshProUGUI ScoreButton;
	

	// Update is called once per frame
	void Update()
	{
		ScoreButton.text = "Score: " + score;
		
	}
}

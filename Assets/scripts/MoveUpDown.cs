using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
private  float HeightVariance = 1f;
	// Update is called once per frame
	void Update()
	{ // sin range = -1 to 1
		transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;
	}
}

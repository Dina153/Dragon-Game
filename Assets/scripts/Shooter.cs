using UnityEngine;

public class Shooter : MonoBehaviour
{ public GameObject projectilePrefab;
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			var projectile = Instantiate(
				projectilePrefab, 
				transform.position + new Vector3(1.5f,0,0),
				projectilePrefab.transform.rotation);
		}
	}
}

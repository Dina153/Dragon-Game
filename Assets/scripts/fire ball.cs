using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class fireball : MonoBehaviour

{ public Vector2 StartingVelocity;
	
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity =StartingVelocity;
		
		Destroy(gameObject,3);
	}
private void OnCollisionEnter2D(Collision2D collision) {
	var enemy = collision.collider.GetComponent<Enemy>();
	enemy?.Die();
	DragonKillerCount.score++;
	Destroy(gameObject);
}
}

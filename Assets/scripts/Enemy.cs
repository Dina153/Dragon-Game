using UnityEngine;

public class Enemy : MonoBehaviour
{
	// SpriteRenderer spriteRenderer;
	// Rigidbody2D rigid_body;
	// private void Start() {
	// 	rigid_body= GetComponent<Rigidbody2D>();
	// 	spriteRenderer = GetComponent<SpriteRenderer>();
	// }
	public void Die()
   {
	GetComponent<SpriteRenderer>().enabled= false;
	// spriteRenderer.enabled= false; 
	GetComponent<Collider2D>().enabled= false; 
	// rigid_body.constraints = RigidbodyConstraints2D.FreezeRotation;
	// spriteRenderer.color = Color.black;
   }
   public void Respawn()
   {
	GetComponent<SpriteRenderer>().enabled= true;
   	// spriteRenderer.enabled= true; 
	GetComponent<Collider2D>().enabled= true; 
   }
}

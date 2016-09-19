using UnityEngine;
using System.Collections;

public class Catapult : MonoBehaviour {

	public Rigidbody projectile;
	public Transform catapult;
	public float force = 1000f;
	public float moveSpeed = 10f;

	void Start () {
		
	}
	
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate(new Vector3(x, y, 0));

		if (Input.GetMouseButtonUp(0))
		{
			Rigidbody ball = (Rigidbody)Instantiate(projectile, catapult.position, catapult.rotation);
			ball.AddForce(catapult.forward * force);
		}
	}
}

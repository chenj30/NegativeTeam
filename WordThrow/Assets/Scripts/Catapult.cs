using UnityEngine;
using System.Collections;

public class Catapult : MonoBehaviour {

	public Rigidbody projectile;
	public Transform catapult;
	public float baseForce = 800;
	public float maxForce = 10000;
	public float timeToMax = 1;
	public float moveSpeed = 10;

	private float _timePressed;
	private float _timeReleased;
	private float _force;

	void Start () {
		_force = baseForce;
	}
	
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate(new Vector3(x, y, 0));

		if (Input.GetMouseButtonDown(0))
		{
			_timePressed = Time.time;
		}

		if (Input.GetMouseButtonUp(0))
		{
			_timeReleased = Time.time;
			Rigidbody ball = (Rigidbody)Instantiate(projectile, catapult.position, catapult.rotation);
			//Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//catapult.position.Set(mousePos.x, mousePos.y, 0);
			//Rigidbody ball = (Rigidbody)Instantiate(projectile, catapult.position, catapult.rotation);
			_force += ((_timeReleased - _timePressed)/timeToMax)*maxForce;
			if (_force > maxForce) { _force = maxForce; }
			ball.AddForce(catapult.forward * _force);
			_force = baseForce;
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Catapult : MonoBehaviour {

	[Header("Required Components")]
	public Rigidbody projectile;
	public Transform catapult;
	public Image crosshair;
	public AudioClip launchSound;
	[Header("Testing values")]
	public float baseForce = 800;
	public float maxForce = 10000;
	public float timeToMax = 1;
	public float distance = 15;

	private AudioSource _audioSource;
	private float _timePressed;
	private float _timeReleased;
	private float _force;

	void Start () {
		_audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	void Update () {
		/* Get mouse position in world space */
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
		/* Set the position of the crosshair to the mouse position */
		crosshair.transform.position = mousePos;

		if (Input.GetMouseButtonDown(0))
		{
			/* Record when mouse button clicked */
			_timePressed = Time.time;
		}


		if (Input.GetMouseButtonUp(0))
		{
			_audioSource.PlayOneShot(launchSound);
			/* Record when mouse button released */
			_timeReleased = Time.time;
			/* Focus the catapult on the mouse position */
			mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance));
			catapult.LookAt(mousePos);
			/* Instantiate the projectile */
			Rigidbody ball = (Rigidbody)Instantiate(projectile, catapult.position, catapult.rotation);
			/* Calculate force based on how long mouse button was held */
			_force = baseForce + ((_timeReleased - _timePressed)/timeToMax)*maxForce;
			if (_force > maxForce) { _force = maxForce; }
			ball.AddForce(catapult.forward * _force);
		}
	}
}

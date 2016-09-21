using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public AudioClip impact;
	public float duration = 5f;

	AudioSource _audioSource;

	void Start () {
		_audioSource = gameObject.GetComponent<AudioSource>();
		Destroy(gameObject, duration);
	}
	
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		_audioSource.PlayOneShot(impact);
		Destroy(gameObject, 1f);
	}
}

using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float duration = 5f;

	void Start () {
		Destroy(gameObject, duration);
	}
	
	void Update () {
	
	}
}

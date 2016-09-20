using UnityEngine;
using System.Collections;

public class spawnWords : MonoBehaviour {
	public GameObject word;
	float spawn_radius = 18.4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.U)) {
			GameObject w = (GameObject) Instantiate (word, transform.position, Quaternion.Euler(new Vector3(0,255,0)));
			Vector3 offset = new Vector3 (Random.Range (-11f, 11f), Random.Range (-5, 5f), Random.Range (-3.25f, 3.25f));
			w.GetComponent<WordBehavior> ().position = offset + transform.position;
			w.GetComponent<WordBehavior> ().word = "wow";
			//FIX ROTATION SOMEHOW
		}
	}
}

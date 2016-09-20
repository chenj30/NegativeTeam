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
			//GameObject w = (GameObject) Instantiate (word, transform.position, Quaternion.Euler(new Vector3(0,0, 255)));
			GameObject w = (GameObject)Instantiate(word, this.transform.position, this.transform.rotation);
			BoxCollider bc = gameObject.GetComponent<BoxCollider>();
			Vector3 offset = new Vector3(Random.Range(-bc.size.z / 2, bc.size.z / 2), Random.Range(-bc.size.y / 2, bc.size.y / 2), Random.Range(-bc.size.x / 2, bc.size.x / 2));
			w.GetComponent<WordBehavior> ().position = offset + transform.position;
			w.GetComponent<WordBehavior> ().word = "Kev";
			w.transform.parent = gameObject.transform;
			//FIX ROTATION SOMEHOW
		}
	}
}

using UnityEngine;
using System.Collections;

public class spawnWords : MonoBehaviour {
	public GameObject word;
	public float timePerSpawn = 3f;
	float spawn_radius = 18.4f;
	float countdown;
	// Use this for initialization
	void Start () {
		countdown = timePerSpawn;
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;
		if (countdown <= 0) {
			GameObject w = (GameObject)Instantiate(word, this.transform.position, this.transform.rotation);
			BoxCollider bc = gameObject.GetComponent<BoxCollider>();
			Vector3 offset = new Vector3(Random.Range(-bc.size.z / 2, bc.size.z / 2), Random.Range(-bc.size.y / 2, bc.size.y / 2), Random.Range(-bc.size.x / 2, bc.size.x / 2));
			w.GetComponent<WordBehavior> ().position = offset + transform.position;
			w.GetComponent<WordBehavior>().wordManager = gameObject.GetComponent<GenerateLevel>();
			w.GetComponent<WordBehavior> ().positive = gameObject.GetComponent<GenerateLevel>().PosOrNeg();
			w.GetComponent<WordBehavior> ().word = gameObject.GetComponent<GenerateLevel>().GetRandomWord(w.GetComponent<WordBehavior>().positive);
			w.transform.parent = gameObject.transform;
			countdown = timePerSpawn;
		}
	}
}

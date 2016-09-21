using UnityEngine;
using System.Collections;

public class WordBehavior : MonoBehaviour {
	public string word = "excellent";
	public Vector3 position;
	public bool positive = false;

	//fadeout
	float fadeout = -1;

	// Use this for initialization
	void Start()
	{
		//first we have to build a word and surround it with a collider
		float width = 0;
		foreach (char letter in word)
		{
			Vector3 location = new Vector3(transform.position.x, transform.position.y, transform.position.z + width);
			GameObject l = (GameObject)Instantiate(Resources.Load("LetterPrefabs/" + letter), location, transform.rotation);
			l.transform.Rotate(new Vector3(0, 180, 0));
			l.transform.parent = transform;
			width += l.GetComponent<MeshRenderer>().bounds.size.x * 3 + 1;
		}
		transform.position = position;
		float duration = gameObject.GetComponentInParent<spawnWords>().timePerSpawn;
		foreach (Rigidbody letter in GetComponentsInChildren<Rigidbody>())
		{
			Destroy(letter, duration);
		}
		Destroy(gameObject, duration);
	}
	
	// Update is called once per frame
	void Update () {
		if (fadeout != -1) {
			foreach (Transform letter in GetComponentsInChildren<Transform>()) {
				letter.localScale = 
				new Vector3 (letter.localScale.x - fadeout,
					letter.localScale.y - fadeout,
					letter.localScale.z - fadeout);
				if (letter.localScale.x < 0) {
					Destroy (letter.gameObject);
					return;
				}
			}
		}
	}

	public void Hit(){
		foreach (Rigidbody letter in GetComponentsInChildren<Rigidbody>()) {
			letter.isKinematic = false;
			letter.velocity = new Vector3 (Random.onUnitSphere.x * 10, 
				Random.onUnitSphere.y * 10,
				Random.onUnitSphere.z * 10);
			letter.GetComponent<BoxCollider>().enabled = false;
			fadeout = .01f;
		}
	}
}

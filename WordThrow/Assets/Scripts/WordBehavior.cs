using UnityEngine;
using System.Collections;

public class WordBehavior : MonoBehaviour {
	public string word = "excellent";
	public Vector3 position;

	//fadeout
	float fadeout = -1;

	// Use this for initialization
	void Start () {
		//first we have to build a word and surround it with a collider
		float width = 0;
		foreach (char letter in word) {
			Vector3 location = new Vector3 (transform.position.x + width, transform.position.y, transform.position.z);
			GameObject l = (GameObject) Instantiate (Resources.Load ("LetterPrefabs/" + letter),location,Quaternion.identity);
			l.transform.parent = transform;
			width += l.GetComponent<MeshRenderer> ().bounds.size.x;
		}
		/*Vector3 old_size = GetComponent<BoxCollider> ().size;
		GetComponent<BoxCollider> ().size = new Vector3 (width, old_size.y, old_size.z);
		GetComponent<BoxCollider> ().center = new Vector3 (transform.position.x + width / 2 - old_size.x/2, transform.position.y, transform.position.z);*/
		//now we can move it wherever we want
		transform.position = position;
		//print ("setting position to " + position);
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
			fadeout = .01f;
		}
	}
}

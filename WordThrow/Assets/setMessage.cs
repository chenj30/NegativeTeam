using UnityEngine;
using System.Collections;

public class setMessage : MonoBehaviour {
	public Sprite negative;
	public Sprite positive;
	public Sprite neutral;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Display(float negativity){
		print ("recieved negativity: " + negativity);
		if (negativity < .33f) {
			sr.sprite = positive;
		} else if (negativity > .33f && negativity < .66f) {
			sr.sprite = neutral;
		} else if (negativity > .66f) {
			sr.sprite = negative;
		} else {
			print ("I chose nothing!");
		}
		sr.enabled = true;
	}
}

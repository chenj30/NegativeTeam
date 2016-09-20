using UnityEngine;
using System.Collections;

public class letterBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		//if any of the letters is hit, it notifies the parent Word
		if (col.gameObject.tag == "Ball") {
			transform.parent.GetComponent<WordBehavior> ().Hit ();
		}
	}
}

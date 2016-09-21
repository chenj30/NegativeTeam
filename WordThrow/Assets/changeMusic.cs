using UnityEngine;
using System.Collections;

public class changeMusic : MonoBehaviour {
	public GameObject wordManager;
	float negativity;
	bool raise = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//[Attach Dan's GenerateLevel Script to Word Manager object before using this]
		
		negativity = wordManager.GetComponent<GenerateLevel>().GetNegativity ();
	
		if (!raise)
			GetComponent<AudioSource> ().pitch -= negativity / 100000;
		else
			GetComponent<AudioSource> ().pitch += negativity / 100000;
		if (GetComponent<AudioSource> ().pitch < .8) {
			raise = true;
		}
		if (GetComponent<AudioSource> ().pitch > 1.2) {
			raise = false;
		}
	}
}

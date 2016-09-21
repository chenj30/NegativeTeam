using UnityEngine;
using System.Collections;

public class setLightByNegativity : MonoBehaviour {

	public GameObject wordManager;
	public float negativity;
	public Color positive_color;
	public Color negative_color;

	// Use this for initialization
	void Start () {
		positive_color = new Color (255.0f/255, 242.0f/255, 208.0f/255);
		negative_color = new Color (200.0f/255, 150.0f/255, 200.0f/255);
		//StartCoroutine ("ChangeLighting");
	}
	
	// Update is called once per frame
	void Update () {
		negativity = wordManager.GetComponent<GenerateLevel> ().GetNegativity ();
		/*
		if (Input.GetKey (KeyCode.R))
			negativity = 0;
		if (Input.GetKey (KeyCode.T))
			negativity = 1;
		*/
		//comment these two lines to stop light changes
		GetComponent<Light> ().color = Color.Lerp (positive_color, negative_color, negativity);
		GameObject.Find ("boncelit").GetComponent<Light> ().intensity = 1.0f - negativity;
	}
		

	IEnumerator ChangeLighting(){
		yield return new WaitForSeconds (5f);
		negativity = wordManager.GetComponent<GenerateLevel>().GetNegativity();
		Color current_color = GetComponent<Light> ().color;
		float timer = 3f;
		while (timer > 0) {
			timer -= Time.deltaTime;
			float percentage = timer / 3f;
			Color.Lerp (current_color, Color.Lerp(positive_color, negative_color, negativity), percentage);
			yield return new WaitForEndOfFrame();
		}
		StartCoroutine ("ChangeLighting");
	}
}

using UnityEngine;
using System.Collections;

public class setLightByNegativity : MonoBehaviour {
	[Range(0.0f,1.0f)]
	public float negativity = .5f;
	public Color positive_color;
	public Color negative_color;

	// Use this for initialization
	void Start () {
		positive_color = new Color (255.0f/255, 242.0f/255, 208.0f/255);
		negative_color = new Color (200.0f/255, 200.0f/255, 200.0f/255);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Light> ().color = Color.Lerp (positive_color, negative_color, negativity);
	}
}

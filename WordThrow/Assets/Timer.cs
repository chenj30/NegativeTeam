using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text text;
	public float game_time;
	bool game_over = false;

	// Update is called once per frame
	void Update () {
		game_time -= Time.deltaTime;
		text.text = ((int)game_time).ToString() + "s";
		if (game_time <= 0) {
			GameObject.Find ("Main Camera").transform.position = GameObject.Find ("End Camera Position").transform.position;
			GameObject.Find ("Main Camera").transform.rotation = GameObject.Find ("End Camera Position").transform.rotation;
			float negativity = GetComponent<GenerateLevel> ().GetNegativity ();
			text.text = "Mindscape Negativity: " + negativity*100 + "%";
			GameObject.Find ("End Message").GetComponent<setMessage> ().Display (negativity);
			game_over = true;
		}

		if (game_over && Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene ("mindscape");
		}
	}
}

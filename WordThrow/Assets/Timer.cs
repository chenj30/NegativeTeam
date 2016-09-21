using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text text;
	public float game_time;

	// Update is called once per frame
	void Update () {
		game_time -= Time.deltaTime;
		text.text = ((int)game_time).ToString() + "s";
		if (game_time <= 0) {
			SceneManager.LoadScene("End Scene");
		}
	}
}

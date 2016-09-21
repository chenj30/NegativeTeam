using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text text;
	public float game_time;

	// Update is called once per frame
	void Update () {
		game_time -= Time.deltaTime;
		text.text = game_time.ToString("F2") + "s";
		if (game_time <= 0) {
			//Load endgame screen.
		}
	}
}

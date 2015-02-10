using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		text.color = Color.white;
		//Time.timeScale = 30f;
	}
	
	// Update is called once per frame
	void Update () {
	
		int minutes = (int)Time.time / 60;
		int seconds = (int)Time.time % 60;

		text.text = string.Format ("{0:D2}:{1:D2}", minutes, seconds);
	}
}

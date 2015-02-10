using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Counter : MonoBehaviour {

	Text counter;
	int count = 0;

	public string[] numbers;

	// Use this for initialization
	void Start () {
	
		counter = GetComponent<Text> ();
		counter.color = Color.white;
	}

	public void AddOneSheep()
	{
		count++;
	}

	// Update is called once per frame
	void Update () {
	
		int stones = count / 10;

		counter.text = string.Format ("{0} stones plus {1}", stones, numbers[count % 10]);
	}
}

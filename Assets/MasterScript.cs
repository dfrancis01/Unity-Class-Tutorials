using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {
	public int score;
	public int health;
	private string display;
	public int level;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}

	void OnGUI(){
		display = score.ToString ();
		GUI.Label (new Rect (10, 10, 100, 20), display);

		/*after animation working*/
		display = health.ToString();
		GUI.Label (new Rect (300, 10, 100, 20), display);
		display = level.ToString ();
		GUI.Label (new Rect (500, 10, 100, 20), display);

	}

	// Update is called once per frame
	void Update () {
		if (score > 2000) {
			level = 3;
		} else if (score > 1000) {
			level = 2;
		} else {
			level = 1;
		}
	
	}
}

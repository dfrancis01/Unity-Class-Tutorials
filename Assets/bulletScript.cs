using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector2 (this.transform.position.x + speed, this.transform.position.y);

		//this will destroy after past the stage
		if (this.transform.position.x > 20) {
			Destroy (this.gameObject);
		}
	}
}

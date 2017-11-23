using UnityEngine;
using System.Collections;

public class playerInput : MonoBehaviour {
	public float speed;
	public GameObject bullet;
	private int timer;
	public int timeout;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y + speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y - speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.position = new Vector2 (this.transform.position.x - speed, this.transform.position.y);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position = new Vector2 (this.transform.position.x + speed, this.transform.position.y);
		}
		if (Input.GetKey (KeyCode.Space) && timer == timeout) {
			Instantiate (bullet, this.transform.position, Quaternion.identity);
			GetComponent<Animator> ().SetTrigger ("shoot");
			timer = 0;
		}
		if (timer < timeout) {
			timer++;
		}
	}
}

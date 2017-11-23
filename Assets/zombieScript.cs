using UnityEngine;
using System.Collections;

public class zombieScript : MonoBehaviour {
	public Transform player;
	public float speed;

	public MasterScript master;

	// Use this for initialization
	void Start () {

	}
	//this method will activate when something enters the collider area
	void OnTriggerEnter2D(Collider2D thing){
		master.score += 100;
		Destroy (thing.gameObject);
		Destroy (this.gameObject);
	}
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y > player.position.y) {
			this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y - speed);
		} else {
			this.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y + speed);
		}
		if (this.transform.position.x > player.position.x) {
			this.transform.position = new Vector2(this.transform.position.x - speed, this.transform.position.y);
		} else {
			this.transform.position = new Vector2(this.transform.position.x + speed, this.transform.position.y);
		}
	}
}

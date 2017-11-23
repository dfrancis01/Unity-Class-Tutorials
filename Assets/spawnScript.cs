using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {
	public GameObject zombo;

	private int timer;
	public int timeout;
	public float xSpawn;
	public float ySpawn;
	public float yRange;
	public Transform player;
	private zombieScript zombi;
	private GameObject temp;

	public MasterScript master;

	// Use this for initialization
	void Start () {
		temp = GameObject.FindGameObjectWithTag ("master");
		master = temp.GetComponent<MasterScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timer >= timeout) {
			ySpawn = Random.Range (-yRange, yRange);
			temp = (GameObject) Instantiate (zombo, new Vector2(xSpawn,ySpawn),Quaternion.identity);
			zombi = temp.GetComponent<zombieScript> ();
			zombi.player = player;
			zombi.master = master;
			timer = 0;
		} else {
			timer++;
		}
	}
}

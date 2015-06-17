using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	// Use this for initialization
	public GameObject crate;
	public float spawnTime = 1f;
	void Spawn () {

		GameObject crate =(GameObject)Instantiate((GameObject)Resources.Load("crate"));
		crate.transform.position = this.transform.position;
	}
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		//Invoke("Spawn", spawnTime);

	}
	
	// Update is called once per frame
	void Update () {
	

	}
}

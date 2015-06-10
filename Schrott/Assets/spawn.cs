using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	// Use this for initialization
	public GameObject crate;
	void Spawn () {
		GameObject crate =(GameObject)Instantiate((GameObject)Resources.Load("crate"));
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		Spawn ();
	}
}

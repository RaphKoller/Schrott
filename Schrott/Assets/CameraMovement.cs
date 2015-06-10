using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	public 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		position.y += 0.03f;
		this.transform.position = position;
	}
}

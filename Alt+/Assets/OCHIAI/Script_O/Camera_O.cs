using UnityEngine;
using System.Collections;

public class Camera_O : MonoBehaviour {
	public Vector3 SPEED = new Vector3(0.5f, 0.5f, 0.5f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Position = transform.position;

		Position.x += SPEED.x;

		transform.position = Position;
	}
}

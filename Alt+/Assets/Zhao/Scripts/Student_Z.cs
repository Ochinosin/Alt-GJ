using UnityEngine;
using System.Collections;

public class Student_Z : MonoBehaviour {
	bool stop = false;
	float time = 0.7f;
	public static int turnNum = 0;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}

	// Update is called once per frame
	void Update () {
		if (stop == false) 
		{
			transform.Translate (new Vector3(0,0,-0.5f) * Time.deltaTime);
			time -= Time.deltaTime;
			if (time <= 0) {
				stop = true;
			}
		}
		if (stop == true) {
			if (turnNum == 1) 
			{
				transform.Translate (new Vector3(3f,0,0) * Time.deltaTime);
			}
			if (turnNum == 2) 
			{
				transform.Translate (new Vector3(-5f,0,0) * Time.deltaTime);
			}
		}
	}
}

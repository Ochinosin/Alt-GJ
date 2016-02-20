using UnityEngine;
using System.Collections;

public class Football_Z : MonoBehaviour {

	bool stop = false;
	float time = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (stop == false) 
		{
			transform.Translate (0,0,-0.1f);
			time -= Time.deltaTime;
			if (time <= 0) {
				stop = true;
			}
		}
	}
}

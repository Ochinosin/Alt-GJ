using UnityEngine;
using System.Collections;

public class Student_Z : MonoBehaviour {
	bool stop = false;
	float time;
	public static int turnNum = 0;
	public static int road = 0;

	void Start () {
		Destroy (gameObject, 5f);
		if (road == 1)
			time = 0.25f;
		if (road == 2)
			time = 0.4f;
	}
		
	void Update () {
		if (stop == false) 
		{
			transform.Translate (new Vector3(0,0,-5f) * Time.deltaTime);
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

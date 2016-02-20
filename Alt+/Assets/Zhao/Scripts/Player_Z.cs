using UnityEngine;
using System.Collections;

public class Player_Z : MonoBehaviour {

	GameObject character;
	Vector3 teacherPoint;
	Vector3 forse;
	int x;
	// Use this for initialization
	void Start () {
		character = GetComponent<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0.1f,0,0);
		teacherPoint = this.transform.position;
		teacherPoint.x -= 10f;
		x = Random.Range (1, 100);
		if (x < 1) {
			var prefab = Resources.Load("Teacher");
			GameObject teacher = Instantiate(prefab,teacherPoint,Quaternion.identity) as GameObject;
			var teacherRigidboby = teacher.GetComponent<Rigidbody> ();
			forse = new Vector3 (1,0.5f,0);
			teacherRigidboby.AddForce (forse * 600f);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Player_Z : MonoBehaviour {

	GameObject character;
	Vector3 teacherPoint;
	public Vector3 forse ;
	public float power = 6f;
	void Start () {
		character = GetComponent<GameObject> ();

	}

	void Update () {
		transform.Translate (0.1f,0,0);
		teacherPoint = this.transform.position;
		teacherPoint.x -= 10f;

	}

	void OnTriggerEnter()
	{
		if (GetComponent<Collider>().tag == "") 
		{
			var prefab = Resources.Load("Teacher");
			GameObject teacher = Instantiate(prefab,teacherPoint,Quaternion.identity) as GameObject;
			var teacherRigidboby = teacher.GetComponent<Rigidbody> ();
			teacherRigidboby.AddForce (forse * power*150f);
		}
	}
}

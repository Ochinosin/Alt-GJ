using UnityEngine;
using System.Collections;

public class Player_O : MonoBehaviour {
	public Vector3 SPEED = new Vector3(0.5f, 0.5f, 0.5f);
	CharacterController characterControllar;
	Vector3 teacherPoint;
	public Vector3 forse ;
	public float power = 6f;
	public GameObject Canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	void Move()
	{
		Vector3 Position = transform.position;

		//if (Input.GetKey("right"))
		//{
			Position.x += SPEED.x;
		//}
		//else 
			if (Input.GetKey("left"))
		{
			Position.x -= SPEED.x;
		}
		else if (Input.GetKey("up"))
		{
			Position.z += SPEED.z;
		}
		else if (Input.GetKey("down"))
		{
			Position.z -= SPEED.z;
		}
		transform.position = Position;
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "ClearArea") {
			Canvas.GetComponent<GameManager_O> ().state = 1;
		}
		if (c.tag == "Wall")
		{
			Vector3 Position = transform.position;
			Position.z -= 0.5f;
		}
		if (c.tag == "Wall2")
		{
			Vector3 Position = transform.position;
			Position.z += 0.5f;
		}
		if (GetComponent<Collider>().tag == "") 
		{
			var prefab = Resources.Load("Teacher");
			GameObject teacher = Instantiate(prefab,teacherPoint,Quaternion.identity) as GameObject;
			var teacherRigidboby = teacher.GetComponent<Rigidbody> ();
			teacherRigidboby.AddForce (forse * power*150f);
		}
	}
}

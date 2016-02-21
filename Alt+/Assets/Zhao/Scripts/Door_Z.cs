using UnityEngine;
using System.Collections;

public class Door_Z : MonoBehaviour {

	GameObject player;
	public GameObject rotate;
	Vector3 ballPosition;
	Vector3 studentPosition;
	float distance;
	bool doorOpen = false;
	bool studentAppear = false;
	bool iteam = false;
	float openTime = 3f;
	float fallTime = 200;
	float shaketime = 0f;
	public int random;
	public int ballorpeople;
	public float ballSpead;
	public int studentTurn;
	public bool roadOnLeft;
	public float distanceOfDoorShake;
	public float distanceOfDoorOpen;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		ballPosition = gameObject.transform.position;
		ballPosition.z += 3f; 
		studentPosition = gameObject.transform.position;
		studentPosition.z += 1f;
		openTime /= 10f;
		if (roadOnLeft == true) 
		{
			Student_Z.road = 1;
		}
		if (roadOnLeft == false) 
		{
			Student_Z.road = 2;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector2.Distance (player.transform.position, gameObject.transform.position);
		if (distance <= distanceOfDoorOpen) 
		{
			if (random  == 1) 
			{
				if (doorOpen == false)
				{
					transform.Translate (-0.1f, 0, 0);
					openTime -= Time.deltaTime;
					if (openTime <= 0) 
					{
						if (ballorpeople == 1) 
						{
							ballPosition.y -= 0.3f;
							var prefab1 = Resources.Load ("Football");
							GameObject football = Instantiate (prefab1, ballPosition, Quaternion.identity) as GameObject;
							var teacherRigidboby = football.GetComponent<Rigidbody> ();
							Vector3 forse = new Vector3 (0,0.2f,-1);
							teacherRigidboby.AddForce (forse * ballSpead * 100f);
						}

						doorOpen = true;
					}
					if (ballorpeople == 2 && studentAppear == false)
					{
						var prefab2 = Resources.Load ("Student");
						GameObject student = Instantiate (prefab2, studentPosition, Quaternion.identity) as GameObject;
						Student_Z.turnNum = studentTurn;
						studentAppear = true;
					}

				}
			}

			if (random  == 2) 
			{
				if(transform.localEulerAngles.x >=270 ||transform.localEulerAngles.x ==0 )
					transform.RotateAround (rotate.transform.position , Vector3.left , fallTime * Time.deltaTime );

			}


		} 
		else if (distance <= distanceOfDoorShake) 
		{
			shaketime += 1;
			transform.position =  new Vector3(transform.position.x + Mathf.Sin(shaketime)/50, transform.position.y , transform.position.z );
		}
	}
}

using UnityEngine;
using System.Collections;

public class Door_Z : MonoBehaviour {

	GameObject player;
	public GameObject rotate;
	Vector3 doorPosition;
	float distance;
	bool doorOpen = false;
	bool iteam = false;
	float openTime = 0.3f;
	float fallTime = 200;
	float time = 0f;
	public int random;
	public int ballorpeople;
	public float ballSpead;
	public int studentTurn;
	public float distanceOfDoorShake;
	public float distanceOfDoorOpen;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		doorPosition = gameObject.transform.position;
		doorPosition.z += 3f; 
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector2.Distance (player.transform.position, doorPosition);
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
							doorPosition.y -= 0.3f;
							var prefab1 = Resources.Load ("Obj_Football");
							GameObject football = Instantiate (prefab1, doorPosition, Quaternion.identity) as GameObject;
							var teacherRigidboby = football.GetComponent<Rigidbody> ();
							Vector3 forse = new Vector3 (0,0.2f,-1);
							teacherRigidboby.AddForce (forse * ballSpead * 100f);
						}

						if (ballorpeople == 2)
						{
							var prefab2 = Resources.Load ("Student");
							GameObject student = Instantiate (prefab2, doorPosition, Quaternion.identity) as GameObject;
							Student_Z.turnNum = studentTurn;
						}

						doorOpen = true;
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
			time += 1;
			transform.position =  new Vector3(transform.position.x + Mathf.Sin(time)/50, transform.position.y , transform.position.z );
		}
	}
}

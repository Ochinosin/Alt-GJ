using UnityEngine;
using System.Collections;

public class Door_Z : MonoBehaviour {

	GameObject player;
	public GameObject rotate;
	public GameObject doorL;
	public GameObject doorR;
	Vector3 ballPosition;
	Vector3 studentPosition;
	private float distance;
	private bool doorOpen = false;
	private bool studentAppear = false;
	private bool iteam = false;
	private float openTime = 3f;
	private float openSpeed = 15f;
	private float fallTime = 200;
	private float shaketime = 0f;
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
		ballPosition.y += 2f; 
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
					doorL.transform.Translate (new Vector3(-openSpeed, 0, 0) * Time.deltaTime);
					doorR.transform.Translate (new Vector3(openSpeed, 0, 0) * Time.deltaTime);
					openTime -= Time.deltaTime;
					if (openTime <= 0) 
					{
						if (ballorpeople == 1) 
						{
							var prefab1 = Resources.Load ("Football");
							GameObject football = Instantiate (prefab1, ballPosition, Quaternion.identity) as GameObject;
							var teacherRigidboby = football.GetComponent<Rigidbody> ();
							Vector3 forse = new Vector3 (0,0.2f,-1);
							teacherRigidboby.AddForce (forse * ballSpead * 1000f);
						}
						if (ballorpeople == 2)
						{
							var prefab2 = Resources.Load ("Student");
							GameObject student = Instantiate (prefab2, studentPosition, Quaternion.identity) as GameObject;
							Student_Z.turnNum = studentTurn;
						}
						doorOpen = true;
					}

				}
			}

			if (random  == 2) 
			{
				if(transform.localEulerAngles.x >=271 ||transform.localEulerAngles.x ==0 )
					transform.Rotate (Vector3.left * 3f,Space.World) ;
				if (transform.localEulerAngles.x == 270)
					doorL.GetComponent<BoxCollider> ().enabled = false;
					doorR.GetComponent<BoxCollider> ().enabled = false;

			}


		} 
		else if (distance <= distanceOfDoorShake) 
		{
			shaketime += 1;
			transform.position =  new Vector3(transform.position.x + Mathf.Sin(shaketime)/10, transform.position.y , transform.position.z );
		}
	}
}

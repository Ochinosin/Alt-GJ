using UnityEngine;
using System.Collections;

public class Door_Z : MonoBehaviour {

	GameObject player;
	public GameObject rotate;
	Vector3 doorPosition;
	float distance;
	bool doorOpen = false;
	bool iteam = false;
	float openTime = 0.5f;
	float fallTime = 200;
	float time = 0f;
	int random;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		doorPosition = gameObject.transform.position;
		doorPosition.y -= 0.45f;
		//random = Random.Range (3,5);
		random = 3;
		Debug.Log (random);
		Debug.Log (random % 3);
	}
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector2.Distance (player.transform.position, doorPosition);
		if (distance <= 5f) {
			if (random % 3 == 0) 
			{
				if (doorOpen == false) 
				{
					transform.Translate (-0.1f, 0, 0);
					openTime -= Time.deltaTime;
					if (openTime <= 0) 
					{
						var prefab = Resources.Load("Obj_Football");
						GameObject football = Instantiate(prefab,doorPosition,Quaternion.identity) as GameObject;
						doorOpen = true;
					}
				}
			}

			if (random % 3 == 1) 
			{
				if(transform.localEulerAngles.x >=270 ||transform.localEulerAngles.x ==0 )
					transform.RotateAround (rotate.transform.position , Vector3.left , fallTime * Time.deltaTime );

			}

		} else if (distance <= 10f) 
		{
			time += 1;
			transform.position =  new Vector3(transform.position.x + Mathf.Sin(time)/50, transform.position.y , transform.position.z );
		}
	}
}

using UnityEngine;
using System.Collections;

public class playermove_s : MonoBehaviour {

    public Vector3 SPEED = new Vector3(0.5f, 0.5f, 0.5f);
    CharacterController characterControllar;
    NavMeshAgent agent;
   

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();        

    }
	// Update is called once per frame
	void Update () {

        Move();
        
    }
    void Move()
    {
        Vector3 Position = transform.position;
       

        if (Input.GetKey("right"))
        {
            Position.x += SPEED.x;
        }
        else if (Input.GetKey("left"))
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

}

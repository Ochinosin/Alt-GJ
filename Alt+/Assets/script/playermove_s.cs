using UnityEngine;
using System.Collections;

public class playermove_s : MonoBehaviour {

    public Vector3 SPEED = new Vector3(0.5f, 0.5f, 0.5f);
    CharacterController characterControllar;
    
   

    // Use this for initialization
    void Start()
    {
      

    }
	// Update is called once per frame
	void Update () {
      Move();
        
    }
    void Move()
    {

        Vector3 Position = transform.position;
        int i = 1;

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

        /*
       
        for (i = 1; i < 3; i++)
        {
            if (i == 1)
            {
                if (Input.GetKey("a"))
                {
                    GetComponent<BoxCollider>().enabled = false;
                    i = 2;
                }
            }
            if (i == 2)
            {
                if (Input.GetKey("a"))
                {
                    GetComponent<BoxCollider>().enabled = false;
                    i = 3;
                }
            }
            if (i == 3)
            {
                if (Input.GetKey("a"))
                {
                    GetComponent<BoxCollider>().enabled = true;
                 
                }
            }
        }
        */
      
  


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "")
        {
            Vector3 Position = transform.position;
            Position.x -= 0.5f;
        }
    }

     

}

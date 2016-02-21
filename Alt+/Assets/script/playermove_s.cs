using System;
using UnityEngine;
using System.Collections;

public class playermove_s : MonoBehaviour {

    public Vector3 SPEED = new Vector3(0.5f, 0.5f, 0.5f);
    CharacterController characterControllar;
    int cnt = 0;
    float countTime;


    // Use this for initialization
    void Start()
    {
        characterControllar = GetComponent<CharacterController>();
        Collider collider = GetComponent<Collider>();

    }
	// Update is called once per frame
	void Update () {
      Move();
        countTime -= Time.deltaTime;
        if (countTime <= 0)
            countTime = 0;
        if(countTime == 0)
            gameObject.GetComponent<BoxCollider>().enabled = true;

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
        
        if (Input.GetKeyDown(KeyCode.A))
        {

            cnt += 1;
            countTime = 3f;
            if (cnt == 1)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;

            }
            if (cnt == 2)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }

            if (cnt == 3)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
            if (cnt >= 4)
            {
                gameObject.GetComponent<BoxCollider>().enabled = true;
            }

            Debug.Log(cnt);
        }
       

       
       
        


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="enemy")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (other.tag == "")
        {
            Vector3 Position = transform.position;
            Position.x -= 0.5f;
        }
    }

     

}

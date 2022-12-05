using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public string left;
    public string right;
    public string up;
    public string down;
    public string RotateR;
    public string RotateL;
    public string fire;




    // Start is called before the first frame update
    public Rigidbody2D myRigidcharacter;
    public float lastFired;
    public GameObject bullet;
    // public float power = 1500f;
    public float moveSpeed = 2f;


    void Start()
    {
        lastFired = 0;
        myRigidcharacter = this.GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(up))
        {
            this.transform.Translate(new Vector3(0f, 5f, 0f)
            * Time.deltaTime * 1);
   
        }   




        if (Input.GetKey(down))
        {
            this.transform.Translate(new Vector3(0f, -5f, 0f)
            * Time.deltaTime * 1);
        }

        if (Input.GetKey(right))
        {
            this.transform.Translate(new Vector3(5f, 0f, 0f)
            * Time.deltaTime * 1);

        }

        if (Input.GetKey(left))
        {
            this.transform.Translate(new Vector3(-5f, 0f, 0f)
            * Time.deltaTime * 1);

        }

        if (Input.GetKey(RotateR))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -200f)
               * Time.deltaTime);
        }

        if (Input.GetKey(RotateL))
        {
            this.transform.Rotate(new Vector3(0f, 0f,
                200f) * Time.deltaTime);
        }


        if (Input.GetKey(fire))
        {
            if (Time.time > lastFired + 1)
            {
                Instantiate(bullet, this.transform.position +
                     (this.transform.up * 1), this.transform.rotation);
                lastFired = Time.time;

            }


        }


    }
}


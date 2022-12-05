using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D myRigid;
    //GameStateManager gsm;
    //private Vector3 playerPos;

    // Use this for initialization
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        //playerPos = GameObject.Find("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.up * 1);

        //this.transform.localScale -= (new Vector3(0.1f, 0.1f, 0.1f));

        //gsm = GameObject.Find("GameState").GetComponent<GameStateManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //GameObject gob = collision.gameObject;

        if (collision.gameObject.tag == "Blue")
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(1);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Skull")
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(1);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "GreenMonster")
        {
            Debug.Log("Collision");
            Destroy(collision.gameObject);
            GameObject.Find("GameStateManager").GetComponent<GameStateManager>().adjustScore(2);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Wall")
            Destroy(gameObject);

    }
}

//if (Input.GetKeyDown("s"))
//{
    //myRigid.transform.Translate(new Vector3(0f, 0.01f, 0f));
    //myRigid.transform.Translate(playerPos);

//}
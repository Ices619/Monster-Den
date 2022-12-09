using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D myRigid;

 
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
     
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.up * 1);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        //These are the GameObjects with these certain tags will be destroyed and add a point to the score system
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
        //This soley destroys the bullet so it doesn't wander out of the screen forever
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    

    }
}

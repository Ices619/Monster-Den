using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    //Sets variables
    public GameObject Player1;
    public float speed;

    private float distance;
    void Start()
    {
        
    }

    // in void Update, the slime will follow after the player1 gameobject
    void Update()
    {
        distance = Vector3.Distance(transform.position, Player1.transform.position);
        Vector3 direction = Player1.transform.position - transform.position;
   

        transform.position = Vector3.MoveTowards(this.transform.position, Player1.transform.position, speed * Time.deltaTime);

    }
}

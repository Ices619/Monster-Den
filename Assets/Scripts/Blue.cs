using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public GameObject Player1;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, Player1.transform.position);
        Vector3 direction = Player1.transform.position - transform.position;
   

        transform.position = Vector3.MoveTowards(this.transform.position, Player1.transform.position, speed * Time.deltaTime);

    }
}

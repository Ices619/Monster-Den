using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMonster : MonoBehaviour
{
    //Sets variables
    public Transform Player1;
    public float speed;
    private SpriteRenderer spriteRenderer;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is used to follow the player and flip the sprite in the direction of the player
    void Update()
    {
        distance = Vector3.Distance(transform.position, Player1.transform.position);
        Vector3 direction = Player1.transform.position - transform.position;



        transform.position = Vector3.MoveTowards(this.transform.position, Player1.transform.position, speed * Time.deltaTime);

        this.spriteRenderer.flipX = Player1.transform.position.x > this.transform.position.x;
    }
}

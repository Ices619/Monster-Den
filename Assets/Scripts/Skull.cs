using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    //Player1 is seen as a trnsform and loads sprite variable
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
        //Gets the Sprite from unity
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update void tells the skull sprite to follow Player1 and will flip the sprite image depending  on the player direction with a localScale
    void Update()
    {
        distance = Vector3.Distance(transform.position, Player1.transform.position);
        Vector3 direction = Player1.transform.position - transform.position;

 

        transform.position = Vector3.MoveTowards(this.transform.position, Player1.transform.position, speed * Time.deltaTime);
        transform.localScale = new Vector3(0.15F, 0.15f, 0.15f);

        this.spriteRenderer.flipX = Player1.transform.position.x > this.transform.position.x;
    }
}

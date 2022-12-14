using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cavedoor : MonoBehaviour
{
    //sets the varibales of gamestate and wheretogo
    public string whereToGo;
    public GameObject gs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //In this private void. I made a oncollisiontrigger so when the player walks up to this object, it will transport them to another scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject gob = collision.gameObject;
        Rigidbody2D colrig;

        if (gob.tag == "")
        {
            colrig = gob.GetComponent<Rigidbody2D>();

            colrig.AddForce(this.gameObject.transform.up * 500);
            colrig.AddTorque(Random.Range(-10, 10));
        }

        if (gob.tag == "Player")
        {
            SceneManager.LoadScene(whereToGo);
        }
    }

}

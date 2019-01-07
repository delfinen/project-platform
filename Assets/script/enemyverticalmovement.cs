using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyverticalmovement : MonoBehaviour
{

    public bool up = true;
    public float speed = 4f;
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {    // hämtar componenten rigidbody2d.                                 
        rbody = GetComponent<Rigidbody2D>();
    }



    // den syns bara i unity. fixedupdate händer när vi vill att den ska hända. medans update händer hela tiden
    private void FixedUpdate()
    {   // om man klickar vänster knapp så får man fart åt -minus höger aka vänster (-x) och om man inte klickar vänster och klickar höger får man fart åt höger sida x
        if (up == true)
        {
            rbody.velocity = -(Vector2)transform.up * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.up * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {    // om den nuddar den osynliga vägen så bytter den från vänster till inte vänster (höger)
        if (collision.tag == "invsiblewall")
        {
            up = !up;
        }
    }

}

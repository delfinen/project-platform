using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // gör så att variablen fungerar likadant i alla script.                     
    public static int score;

    public int amount = 1;

    private float spinspeed = 180;

    private void Update()
    {
        // gör så att objectet (coin) snurrar 180 grader i sekunden
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);

    }
    // Use this for initialization

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {   // när spelaren rör coinen så får han +1 poäng och coinen förstörs.
        if(collision.tag == "Player")
        {
            coin.score += amount;
            Destroy(gameObject);
        }
    }
}

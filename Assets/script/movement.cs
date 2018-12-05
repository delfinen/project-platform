using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    
    public float movespeed = 6f;
    
    public float jumpspeed = 12f;
    
    private Rigidbody2D rbody;
    
    public groundchecker groundcheck;

	// Use this for initialization
	void Start () {
        // Hämtar componenten Rigidbody2d när spelet startar.
        rbody = GetComponent<Rigidbody2D>();




	}
	
	// Update is called once per frame
	void Update () {
        
        {
            // man får axeln horizontalt och får fart så när man klickar på space får man fart uppåt.
            rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);

            //när man klicka på hopp knappen (space) kollar checkar den om man är på marken (isgrounded = true) och om du är på marken och klickar space får du fart uppåt du får hoppfart
            if (Input.GetButtonDown("Jump"))
            {

                if(groundcheck.isgrounded == true  )

                rbody.velocity = new Vector2( rbody.velocity.x, jumpspeed);
            }
          
        }



        if (Input.GetKey(KeyCode.S))
        {
            
        }
    }
}
                             

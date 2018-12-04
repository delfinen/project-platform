using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissappearingground : MonoBehaviour

{   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   //när spelaren nuddar/kommer i kontakt så händer något. Det som händer är att objectet förstörs efter en sekund.
        if (collision.tag == "Player")
        {
            Object.Destroy(gameObject, 0.5f);
        }
    }

}

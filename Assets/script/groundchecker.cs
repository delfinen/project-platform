using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour {


    public bool isgrounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {   // man är på marken den är true
        isgrounded = true            ;
    }

    // när man slutar ha kontakt så händer något
    private void OnTriggerExit2D(Collider2D collision)
    {    // man är inte på marken den är false
        isgrounded = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour {


    public int isgrounded;
    private void OnTriggerEnter2D(Collider2D collision)
    {   // man är på marken
        isgrounded++            ;
    }

    // när man slutar ha kontakt så händer något
    private void OnTriggerExit2D(Collider2D collision)
    {    // man är inte på marken
        isgrounded--;
    }
}

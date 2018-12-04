using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setspriteinv : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // gör så att hämta spriterender componenten är false dvs att den gör så att i spelet så avaktiveras den.
        GetComponent<SpriteRenderer>().enabled = false;

    }

   
}

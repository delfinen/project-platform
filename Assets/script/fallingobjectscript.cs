using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingobjectscript : MonoBehaviour
{


    public float fallspeed = 40.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   // gör så att den åker neråt på y axeln med farten 40, gör så att den åker neråt från världens perspektiv
        transform.Translate(Vector3.down * fallspeed * Time.deltaTime, Space.World);
    }
}

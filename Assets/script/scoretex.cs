using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretex : MonoBehaviour
{


    private TextMeshProUGUI text;
    // Use this for initialization
    void Start()
    {   // hämtar en egen text component.
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {   // gör så att man får upp text i spelet som är 000 och att det är coin score dvs när man tar coin så ska den ändra till hur mycket den är värd
        text.text = string.Format("Score: {0:000}", coin.score);

    }
}

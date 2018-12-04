using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {
    public int miniumscoreneeded = 0;

    public string scenetoload = "level";

    // när man får kontakt med något så händer något
    private void OnTriggerEnter2D(Collider2D collision)
    {   // om spelaren nuddar och tar tillräckligt mycket coins (minimum needed) så kan dem klara spelet nu är den på 0 så man behöver inga coins
        if(collision.tag == "Player" && coin.score >= miniumscoreneeded)
        {
            coin.score = 1;
            SceneManager.LoadScene(scenetoload);
        }
    }


}

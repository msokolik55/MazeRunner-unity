using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitControl : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == MainGame.PlayerName)
        {
            if(MainGame.CurrentID % MainGame.CountLevels == 0)
            {
                SceneManager.LoadScene("Congrats");
            }
            else
            {
                MainGame.CurrentID++;
                SceneManager.LoadScene("Betweenlevels");
            }
        }
    }
}

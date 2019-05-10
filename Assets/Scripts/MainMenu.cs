using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }
}

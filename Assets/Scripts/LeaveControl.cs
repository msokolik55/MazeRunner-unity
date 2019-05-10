using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaveControl : MonoBehaviour {

    public static bool IsPaused;

    public void Pause()
    {
        IsPaused = true;
    }

    public void Resume()
    {
        IsPaused = false;
    }

    public void Leave()
    {
        IsPaused = false;
        MainGame.CurrentID = 0;
        SceneManager.LoadScene(0);
    }
}

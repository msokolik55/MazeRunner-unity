using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchControl : MonoBehaviour {

    public Text LevelTimeText;
    public Text PlayTimeText;

	// Use this for initialization
	void Start () {
        LevelTimeText.text = "Level time: " + Timer.TimeFormat(Timer.LevelTime);
        PlayTimeText.text = "Overall time: " + Timer.TimeFormat(Timer.PlayTime);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(MainGame.CurrentID);
    }
}

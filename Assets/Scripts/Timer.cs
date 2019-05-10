using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimerText;
    public Text LevelTimeText;

    public static float PlayTime;
    public static float LevelTime;

    // Use this for initialization
    void Start () {
        LevelTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (!LeaveControl.IsPaused)
        {
            // overall game time
            PlayTime += Time.deltaTime;
            TimerText.text = TimeFormat(PlayTime);

            // single level time
            LevelTime += Time.deltaTime;
            LevelTimeText.text = TimeFormat(LevelTime);
        }
    }

    public static string TimeFormat(float t)
    {
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("00.00");

        return(minutes + ":" + seconds);
    }
}

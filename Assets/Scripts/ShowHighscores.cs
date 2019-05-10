using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighscores : MonoBehaviour {

    public Text HighscoreEasy;
    public Text HighscoreMedium;
    public Text HighscoreHard;
    
    // Use this for initialization
    void Start () {
        HighscoreEasy.text = Timer.TimeFormat(PlayerPrefs.GetFloat("HighscoreEasy", 0));
        HighscoreMedium.text = Timer.TimeFormat(PlayerPrefs.GetFloat("HighscoreMedium", 0));
        HighscoreHard.text = Timer.TimeFormat(PlayerPrefs.GetFloat("HighscoreHard", 0));
    }
}

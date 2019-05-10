using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public Text FinalTime;
    public Text BestTime;

    private string[] keys = new string[] { "HighscoreEasy", "HighscoreMedium", "HighscoreHard" };

    // Use this for initialization
    void Start ()
    {
        FinalTime.text = "Your time: " + Timer.TimeFormat(Timer.PlayTime);

        for(int i = 1; i <= keys.Length; i++)
        {
            if (MainGame.Difficulty == i)
            {
                if ((Timer.PlayTime < PlayerPrefs.GetFloat(keys[i - 1], 0)) || (PlayerPrefs.GetFloat(keys[i - 1], 0) == 0))
                {
                    PlayerPrefs.SetFloat(keys[i - 1], Timer.PlayTime);
                }

                BestTime.text = "Best time: " + Timer.TimeFormat(PlayerPrefs.GetFloat(keys[i - 1], 0));
            }
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

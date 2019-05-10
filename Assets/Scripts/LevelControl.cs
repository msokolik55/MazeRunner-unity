using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour {

    public Text LevelText;

	// Use this for initialization
	void Start () {
        MainGame.CurrentID = SceneManager.GetActiveScene().buildIndex;

        int currentLevel = MainGame.CurrentID % MainGame.CountLevels;
        if(currentLevel == 0) { currentLevel = 10; }

        LevelText.text = currentLevel + "/" + MainGame.CountLevels;
	}
}

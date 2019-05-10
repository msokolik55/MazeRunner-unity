using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour {

	public void Easy()
    {
        MainGame.Difficulty = 1;
        SceneManager.LoadScene(MainGame.FirstLevelID);
        SetSpeed();
    }

    public void Meadium()
    {
        MainGame.Difficulty = 2;
        SceneManager.LoadScene(MainGame.FirstLevelID + MainGame.CountLevels);
        SetSpeed();
    }

    public void Hard()
    {
        MainGame.Difficulty = 3;
        SceneManager.LoadScene(MainGame.FirstLevelID + 2 * MainGame.CountLevels);
        SetSpeed();
    }

    void SetSpeed()
    {
        MainGame.MoveSpeed = MainGame.Difficulty * 2;
    }
}

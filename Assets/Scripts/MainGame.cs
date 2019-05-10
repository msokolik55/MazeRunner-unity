using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour {

    public static int CurrentID;
    public static int FirstLevelID = 1;
    
    public static int Money;
    public static int MoveSpeed;
    public static int Difficulty;

    public static int CountLevels = 10;
    public static string PlayerName = "PlayerCharacter";

    public static int[] CountCoins = new int[] { 4, 10, 20 };
    public static int[] MazeSize = new int[] { 5, 10, 15 };

    // Use this for initialization
    void Start() {        
        CurrentID = 0;
        Timer.PlayTime = 0f;

        Money = 0;
    }
}

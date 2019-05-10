using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPrefabMaker : MonoBehaviour {

    public GameObject CoinPrefab;
    GameObject coinPrefabClone;

    private float step = 2.56f;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < MainGame.CountCoins[MainGame.Difficulty - 1]; i++)
        {
            float x = Random.Range(-MainGame.MazeSize[MainGame.Difficulty - 1] / 2, MainGame.MazeSize[MainGame.Difficulty - 1] / 2) * step;
            float y = Random.Range(-MainGame.MazeSize[MainGame.Difficulty - 1] / 2, MainGame.MazeSize[MainGame.Difficulty - 1] / 2) * step;

            coinPrefabClone = Instantiate(CoinPrefab, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
            coinPrefabClone.transform.parent = GameObject.Find("Coins").transform;
        }

        if (MainGame.Difficulty == 2) { GameObject.Find("Coins").GetComponent<Transform>().position = new Vector3(1.3f, 1.5f); }
    }
}

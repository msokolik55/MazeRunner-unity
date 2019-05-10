using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {

    private GameObject coinsText;
    private GameObject coinAudio;

	// Use this for initialization
	void Start () {
        coinsText = GameObject.Find("CoinsAmount");
        coinsText.GetComponent<Text>().text = "Coins: " + MainGame.Money;

        coinAudio = GameObject.Find("CoinSound");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == MainGame.PlayerName)
        {
            coinAudio.GetComponent<AudioSource>().Play();
            Destroy(gameObject);

            MainGame.Money++;
            coinsText.GetComponent<Text>().text = "Coins: " + MainGame.Money;
        }
    }
}

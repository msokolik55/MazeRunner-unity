using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopControl : MonoBehaviour {

    public Text CoinText;
    public Text SpeedText;
    public Text TimeText;
    public Text UpdateTimeText;

    public AudioSource BuyAudioSource;

    private int maxSpeed = 30;
    private float[] bonusTime = new float[] { 3f, 4f, 5f }; 

	// Use this for initialization
	void Start () {
        CoinText.text = "Coins: " + MainGame.Money;
        SpeedText.text = MainGame.MoveSpeed + "/" + maxSpeed;
        TimeText.text = Timer.TimeFormat(Timer.PlayTime);

        UpdateTimeText.text = "Update time: 1coin / " + bonusTime[MainGame.Difficulty - 1].ToString() + "seconds";
    }

    public void BuySpeed()
    {
        if(MainGame.Money > 0 && MainGame.MoveSpeed < maxSpeed)
        {
            MainGame.MoveSpeed++;
            MainGame.Money--;

            SpeedText.text = MainGame.MoveSpeed + "/" + maxSpeed;
            CoinText.text = "Coins: " + MainGame.Money;

            BuyAudioSource.Play();
        }
    }

    public void UpdateTime()
    {
        if (MainGame.Money > 0 && Timer.PlayTime > 0f)
        {
            Timer.PlayTime -= bonusTime[MainGame.Difficulty - 1];
            MainGame.Money--;

            if (Timer.PlayTime < 0f) { Timer.PlayTime = 0f; }

            TimeText.text = Timer.TimeFormat(Timer.PlayTime);
            CoinText.text = "Coins: " + MainGame.Money;

            BuyAudioSource.Play();
        }
    }
}

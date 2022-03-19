using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Custom : MonoBehaviour
{
    public Text coinText;
    public Text levelsText;
    public static int coins;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }
    void Update()
    {
        coinText.text = " X " + coins.ToString();
        levelsText.text = PlayerPrefs.GetInt("Completions").ToString();
    }

    public static void AddCoins()
    {
        AdsUnity.RewardedVideo();
        coins += 10;
        PlayerPrefs.SetInt("Coins", coins);
    }
}

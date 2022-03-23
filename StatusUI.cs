using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    private int _coins;
    private int _life;
    public Text coinText;
    public Text lifeText;
    public Text warning;

    void Update()
    {
        lifeText.color = ChangePlayerColor.textColor;

        _coins = Player.coins;
        _life = Player.life;

        if (Player.warningOn == true)
        {
            if(LevelChange.tutorial == true)
            {
                warning.text = "";
            }
            else
            {
                warning.text = "Collect 10 or more coins!";
            }
        }
        else if(Player.warningOn == false)
        {
            warning.text = "";
        }

        lifeText.text = _life.ToString();

        if (_coins < 10)
        {
            coinText.text = _coins.ToString() + "/10";
            coinText.color = Color.red;
        }
        else
        {
            coinText.text = _coins.ToString();
            coinText.color = Color.green;
        }

        if (_life <= 0)
            lifeText.text = "";
    }
}

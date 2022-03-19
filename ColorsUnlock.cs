using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsUnlock : MonoBehaviour
{
    private int colorUnlock1, colorUnlock2, colorUnlock3, colorUnlock4, colorUnlock5, colorUnlock6, colorUnlock7, colorUnlock8,
                colorUnlock9, colorUnlock10, colorUnlock11;
    
    public GameObject[] ButtonLock;

    private void Awake()
    {
        GetPlayerPrefs();
        DestroyUnlockedButtons();
    }

    #region Methods
    void GetPlayerPrefs()
    {
        colorUnlock1 = PlayerPrefs.GetInt("ColorUnlock1");
        colorUnlock2 = PlayerPrefs.GetInt("ColorUnlock2");
        colorUnlock3 = PlayerPrefs.GetInt("ColorUnlock3");
        colorUnlock4 = PlayerPrefs.GetInt("ColorUnlock4");
        colorUnlock5 = PlayerPrefs.GetInt("ColorUnlock5");
        colorUnlock6 = PlayerPrefs.GetInt("ColorUnlock6");
        colorUnlock7 = PlayerPrefs.GetInt("ColorUnlock7");
        colorUnlock8 = PlayerPrefs.GetInt("ColorUnlock8");
        colorUnlock9 = PlayerPrefs.GetInt("ColorUnlock9");
        colorUnlock10 = PlayerPrefs.GetInt("ColorUnlock10");
        colorUnlock11 = PlayerPrefs.GetInt("ColorUnlock11");
    }
    void DestroyUnlockedButtons()
    {
        if (PlayerPrefs.GetInt("ColorUnlock1") > 0)
        {
            Destroy(ButtonLock[0]); // Color#1
        }
        if (PlayerPrefs.GetInt("ColorUnlock2") > 0)
        {
            Destroy(ButtonLock[1]); // Color#2
        }
        if (PlayerPrefs.GetInt("ColorUnlock3") > 0)
        {
            Destroy(ButtonLock[2]); // Color#3
        }
        if (PlayerPrefs.GetInt("ColorUnlock4") > 0)
        {
            Destroy(ButtonLock[3]); // Color#4
        }
        if (PlayerPrefs.GetInt("ColorUnlock5") > 0)
        {
            Destroy(ButtonLock[4]); // Color#5
        }
        if (PlayerPrefs.GetInt("ColorUnlock6") > 0)
        {
            Destroy(ButtonLock[5]); // Color#6
        }
        if (PlayerPrefs.GetInt("ColorUnlock7") > 0)
        {
            Destroy(ButtonLock[6]); // Color#7
        }
        if (PlayerPrefs.GetInt("ColorUnlock8") > 0)
        {
            Destroy(ButtonLock[7]); // Color#8
        }
        if (PlayerPrefs.GetInt("ColorUnlock9") > 0)
        {
            Destroy(ButtonLock[8]); // Color#9
        }
        if (PlayerPrefs.GetInt("ColorUnlock10") > 0)
        {
            Destroy(ButtonLock[9]); // Color#10
        }
        if (PlayerPrefs.GetInt("ColorUnlock11") > 0)
        {
            Destroy(ButtonLock[10]); // Color#11
        }
    }
    #endregion

    #region OnClick
    public void OnClickBuyColor1()
    {
        if (colorUnlock1 == 0 && Custom.coins >= 10){
            colorUnlock1++;
            if(colorUnlock1 > 2){
                colorUnlock1 = 1;
            }
            Custom.coins -= 10;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock1", colorUnlock1);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[0]);
            SoundKey.KeySound();
        }else{
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor2()
    {
        if (colorUnlock2 == 0 && Custom.coins >= 10)
        {
            colorUnlock2++;
            if (colorUnlock2 > 2)
            {
                colorUnlock2 = 1;
            }
            Custom.coins -= 10;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock2", colorUnlock2);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[1]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor3()
    {
        if (colorUnlock3 == 0 && Custom.coins >= 15)
        {
            colorUnlock3++;
            if (colorUnlock3 > 2)
            {
                colorUnlock3 = 1;
            }
            Custom.coins -= 15;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock3", colorUnlock3);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[2]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor4()
    {
        if (colorUnlock4 == 0 && Custom.coins >= 15)
        {
            colorUnlock4++;
            if (colorUnlock4 > 2)
            {
                colorUnlock4 = 1;
            }
            Custom.coins -= 15;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock4", colorUnlock4);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[3]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor5()
    {
        if (colorUnlock5 == 0 && Custom.coins >= 15)
        {
            colorUnlock5++;
            if (colorUnlock5 > 2)
            {
                colorUnlock5 = 1;
            }
            Custom.coins -= 15;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock5", colorUnlock5);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[4]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor6()
    {
        if (colorUnlock6 == 0 && Custom.coins >= 20)
        {
            colorUnlock6++;
            if (colorUnlock6 > 2)
            {
                colorUnlock6 = 1;
            }
            Custom.coins -= 20;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock6", colorUnlock6);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[5]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor7()
    {
        if (colorUnlock7 == 0 && Custom.coins >= 20)
        {
            colorUnlock7++;
            if (colorUnlock7 > 2)
            {
                colorUnlock7 = 1;
            }
            Custom.coins -= 20;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock7", colorUnlock7);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[6]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor8()
    {
        if (colorUnlock8 == 0 && Custom.coins >= 20)
        {
            colorUnlock8++;
            if (colorUnlock8 > 2)
            {
                colorUnlock8 = 1;
            }
            Custom.coins -= 20;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock8", colorUnlock8);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[7]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor9()
    {
        if (colorUnlock9 == 0 && Custom.coins >= 25)
        {
            colorUnlock9++;
            if (colorUnlock9 > 2)
            {
                colorUnlock9 = 1;
            }
            Custom.coins -= 25;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock9", colorUnlock9);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[8]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor10()
    {
        if (colorUnlock10 == 0 && Custom.coins >= 25)
        {
            colorUnlock10++;
            if (colorUnlock10 > 2)
            {
                colorUnlock10 = 1;
            }
            Custom.coins -= 25;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock10", colorUnlock10);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[9]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    public void OnClickBuyColor11()
    {
        if (colorUnlock11 == 0 && Custom.coins >= 25)
        {
            colorUnlock11++;
            if (colorUnlock11 > 2)
            {
                colorUnlock11 = 1;
            }
            Custom.coins -= 25;
            PlayerPrefs.SetInt("Coins", Custom.coins);
            PlayerPrefs.SetInt("ColorUnlock11", colorUnlock11);
            Debug.Log("Comprou a cor");
            Destroy(ButtonLock[10]);
            SoundKey.KeySound();
        }
        else
        {
            Debug.Log("Você não tem dinheiro!");
            SoundSelect.SelectSound();
        }
    }
    #endregion

}

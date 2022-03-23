using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorialPanel, joystick;

    void Start()
    {
        if (PlayerPrefs.GetInt("Completions") <= 0)
        {
            tutorialPanel.SetActive(true);
            joystick.SetActive(false);
        }
        else
        {
            tutorialPanel.SetActive(false);
        }
    }

    public void OnClickOk()
    {
        tutorialPanel.SetActive(false);
        LevelChange.tutorial = false;
        joystick.SetActive(true);
    }
}
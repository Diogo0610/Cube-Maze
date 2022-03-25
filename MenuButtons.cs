using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject menu, custom, options;

    void Start()
    {
        menu.SetActive(true);
        custom.SetActive(false);
        options.SetActive(false);
    }
    public void OnClickPlayButton()
    {
        SceneManager.LoadScene("Levels");
    }

    public void OnClickCustomButton()
    {
        menu.SetActive(false);
        custom.SetActive(true);
    }
    public void OnClickOptionsButton()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }
    public void OnClickReturnMenuButton()
    {
        menu.SetActive(true);
        custom.SetActive(false);
        options.SetActive(false);
    }
}

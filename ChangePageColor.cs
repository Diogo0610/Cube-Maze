using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePageColor : MonoBehaviour
{
    [SerializeField] GameObject nextPage, previousPage, page1, page2;
    bool isMainPage;
    void Start()
    {
        isMainPage = true;
    }

    void Update()
    {
        if (isMainPage)
        {
            nextPage.SetActive(true);
            previousPage.SetActive(false);
            page1.SetActive(true);
            page2.SetActive(false);          
        }
        else
        {
            nextPage.SetActive(false);
            previousPage.SetActive(true);
            page1.SetActive(false);
            page2.SetActive(true);
        }
    }
    public void OnClickChangeToNextPage()
    {
        isMainPage = false;
    }
    public void OnClickBackToMainPage()
    {
        isMainPage = true;
    }
}

using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public GameObject buttonNextLevel;
    public static bool activeButton;

    public GameObject[] level;
    public Transform target;
    int _ranNum;
    int _levelsClompleted = 0;
    public static bool tutorial;

    private void Awake()
    {
        _levelsClompleted = PlayerPrefs.GetInt("Completions");

        buttonNextLevel.SetActive(false);
        activeButton = false;

        if (PlayerPrefs.GetInt("Completions") <= 0)
        {
            tutorial = true;
            _ranNum = Random.Range(0, 7);
            Instantiate(level[_ranNum], target);
        }
        else
        {
            tutorial = false;
            _ranNum = Random.Range(0, 7);
            Instantiate(level[_ranNum], target);
        }
    }

    private void Update()
    {
        if(activeButton == false)
        {
            buttonNextLevel.SetActive(false);
        }
        else
        {
            buttonNextLevel.SetActive(true);
        }
    }
    public static void ActivateButton()
    {
        activeButton = true;
    }
    public static void DisableButton()
    {
        activeButton = false; ;
    }

    public void OnClickNextLevel()
    {
        Player.coinsAmount += Player.coins;
        PlayerPrefs.SetInt("Coins", Player.coinsAmount);
        _levelsClompleted++;
        PlayerPrefs.SetInt("Completions", _levelsClompleted);
        AdsUnity.InterstitialVideo();
        Destroy(GameObject.FindWithTag("Level"));
        _ranNum = Random.Range(0, 7);
        Instantiate(level[_ranNum], target);
        
    }
}

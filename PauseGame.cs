using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseMenu, pauseButton, joystick, tutorialPanel;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        joystick.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        joystick.SetActive(true);
        Time.timeScale = 1f;
    }
    public void BackMenu()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        joystick.SetActive(true);
        SceneManager.LoadScene("Menu");
    }

    public void Tutorial()
    {
        tutorialPanel.SetActive(true);
    }
}

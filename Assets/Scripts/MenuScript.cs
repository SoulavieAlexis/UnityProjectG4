using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void goToLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void PlayLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

﻿using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Relance ou quitte la partie en cours
/// </summary>
public class GameOverScript : MonoBehaviour
{

    Scene m_scene;
    public string sceneName;
    //public int currentScore;

    void Start()
    {
        m_scene = SceneManager.GetActiveScene();
    }

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;


        //GUI.Label(new Rect(10, 10, 100, 20), currentScore.ToString());
        GUI.Label(new Rect(10, 10, 100, 20), ScoreScript.instance.scorePlayer.ToString());

        if (
          GUI.Button(
            // Centré en x, 1/3 en ys
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Retry!"
          )
        )
        {

            sceneName = m_scene.name;
            // Recharge le niveau
            Application.LoadLevel(sceneName);
        }

        if (
          GUI.Button(
            // Centré en x, 2/3 en y
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Back to menu"
          )
        )
        {
            // Retourne au menu
            Application.LoadLevel("Menu");
        }
    }
}
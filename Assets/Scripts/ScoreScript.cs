using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int scorePlayer;
    public Text pointsCountText;

    public static ScoreScript instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("il y a plus d'une instance de score dans la scène");
            return;
        }
        instance = this;
    }

    public void addPoints(int points)
    {
        scorePlayer += points;
        pointsCountText.text = scorePlayer.ToString();
    }
}

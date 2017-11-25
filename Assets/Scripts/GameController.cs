using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text endText;
    public int maxScore = 10;

    void Start()
    {
        scoreText.text = "Очки 0/" + maxScore;
        endText.text = "";
    }

    public void ChangeScore(int score)
    {
        scoreText.text = "Очки "+ score + "/" + maxScore;
        if (score == maxScore)
        {
            endText.text = "Ты победил";
        }
    }

}

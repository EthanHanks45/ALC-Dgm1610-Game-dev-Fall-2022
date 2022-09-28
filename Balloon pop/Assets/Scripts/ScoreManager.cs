using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int score;// Keep track of score
    public TextMeshProUGUI scoreText;// test UI object to be modified

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    public void InceaseScoreText(int amount)// Increase score by amount
    {
        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScoreText(int amount)// Decrease score by amount
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

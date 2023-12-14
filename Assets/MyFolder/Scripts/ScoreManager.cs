using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int currentScore;
    [SerializeField] private int scoreMax;
    private bool isScoreMaxReached = false;

    [Space]
    public UnityEvent OnScoreFinished;
    [Space]

    public TextMeshProUGUI scoreText;

    void Start()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        if (isScoreMaxReached)
        {
            Debug.Log("Score max reached, cannot add more score.");
            return;
        }

        currentScore += amount;
        UpdateScoreUI();

        CheckScore();
    }

    public void SubtractScore(int amount)
    {
        if (isScoreMaxReached)
        {
            Debug.Log("Score max reached, cannot subtract score.");
            return;
        }

        currentScore -= amount;
        if (currentScore < 0)
        {
            currentScore = 0;
        }
        UpdateScoreUI();

        CheckScore();
    }

    private void CheckScore()
    {
        if (currentScore >= scoreMax && !isScoreMaxReached)
        {
            isScoreMaxReached = true;
            OnScoreFinished.Invoke();
        }
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }
}

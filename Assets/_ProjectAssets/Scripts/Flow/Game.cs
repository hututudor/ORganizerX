using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Timer timer;
    public RuleManager ruleManager;
    public bool isRunning = true; 
    
    public TMPro.TextMeshProUGUI[] scoreDisplays;
    
    public GameObject runningUI;
    public GameObject gameOverSuccessUI;
    public GameObject gameOverFailureUI;

    public void Start()
    {
        runningUI.SetActive(true);
        gameOverSuccessUI.SetActive(false);
        gameOverFailureUI.SetActive(false);
    }
    
    public void Update()
    {
        foreach (TMPro.TextMeshProUGUI scoreDisplay in scoreDisplays)
        {
            scoreDisplay.text = "Score: " + ruleManager.GetScore().ToString();
        }
        
        if (isRunning != timer.isRunning)
        {
            // game over
        }
        
        isRunning = timer.isRunning;
    }

    public void OnGameOver()
    {
        if (ruleManager.IsCorrect())
        {
            OnSuccess();
        }
        else
        {
            OnFailure();
        }
    }
    
    public void OnSuccess()
    {
        runningUI.SetActive(false);
        gameOverSuccessUI.SetActive(true);
        gameOverFailureUI.SetActive(false);
    }
    
    public void OnFailure()
    {
        runningUI.SetActive(false);
        gameOverSuccessUI.SetActive(false);
        gameOverFailureUI.SetActive(true);
    }
}

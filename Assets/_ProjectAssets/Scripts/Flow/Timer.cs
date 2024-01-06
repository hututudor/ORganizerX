using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeInSeconds = 30f; 
    public TMPro.TextMeshProUGUI timerText;
    
    private float remainingTime = 0;
    public bool isRunning = true;

    void Start()
    {
        remainingTime = timeInSeconds;
    }
    
    void Update()
    {
        if (!isRunning)
        {
            return;
        }
        
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            isRunning = false;
            remainingTime = 0;
        }
        
        timerText.text = remainingTime.ToString("0") + "s left";
    }
    
    public void ResetTimer()
    {
        remainingTime = timeInSeconds;
        isRunning = true;
    }
}

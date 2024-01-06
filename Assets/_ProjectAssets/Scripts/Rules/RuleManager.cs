using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    public Rule[] rules;
    private int score;
    
    public void Start()
    {
    }

    public void Update()
    {
        score = 0;
        
        foreach (Rule rule in rules)
        {
            if (rule.IsCorrect())
            {
                // Debug.Log("Rule " + rule.name + " " + rule.GetScore());
                score += rule.GetScore();
            }
        }
    }
    
    public int GetScore()
    {
        return score;
    }
    
    public bool IsCorrect()
    {
        foreach (Rule rule in rules)
        {
            if (!rule.IsCorrect())
            {
                return false;
            }
        }

        return true;
    }
}

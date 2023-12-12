using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : MonoBehaviour
{
	public int customScore;

    public virtual bool IsCorrect() 
	{
		return false;
	}

	public virtual int CalculateScore() 
	{
		return 0;
	} 

	public int GetScore() 
	{
		if (customScore != 0) {
            return customScore;
        }

        return CalculateScore();
	}
}

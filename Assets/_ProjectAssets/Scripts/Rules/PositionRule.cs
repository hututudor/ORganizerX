using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRule : Rule
{
    public Transform target;
    public float threshold;

    public override bool IsCorrect()
    {
		float actualDistance = Vector3.Distance(this.transform.position, target.position);
        return actualDistance < threshold;
    }
    
    public override int CalculateScore() 
	{
        return (int) (threshold - Vector3.Distance(this.transform.position, target.position));
	}
}

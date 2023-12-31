using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceRule : Rule
{
    public Transform target;
    public float distance;
	public bool shouldBeInside;
    
    public override bool IsCorrect()
    {
		float actualDistance = Vector3.Distance(this.transform.position, target.position);
        return shouldBeInside ? actualDistance <= distance : actualDistance >= distance;
    }
    
    public override int CalculateScore() 
	{
		if (shouldBeInside) {
            return (int) (distance - Vector3.Distance(this.transform.position, target.position));
        }

		return (int) Vector3.Distance(this.transform.position, target.position);
	}
}

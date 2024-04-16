using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visionOn : MonoBehaviour
{
    public AudioSource audioSource; 
    public float delay = 5f; 
    public Transform targetObject; 

    private float timeLookingAtTarget; 
    private bool isLookingAtTarget; 

    private void Update()
    {
        
        if (IsLookingAtTarget())
        {
            
            timeLookingAtTarget += Time.deltaTime;

            
            if (timeLookingAtTarget >= delay)
            {
                audioSource.enabled = true;
            }
        }
        else
        {
            
            timeLookingAtTarget = 10f;
        }
    }

    private bool IsLookingAtTarget()
    {
        
        Vector3 playerForward = transform.forward;

        
        Vector3 toTarget = (targetObject.position - transform.position).normalized;

        
        float angle = Vector3.Angle(playerForward, toTarget);

        
        return angle < 30f;
    }
}

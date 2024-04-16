using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightaaa : MonoBehaviour
{
    public float disableTime = 2f; 
    private int triggerCount = 0; 

    private void OnTriggerEnter(Collider other)
    {
        
        triggerCount++;

        
        if (other.gameObject.tag == "Player" && triggerCount == 2)
        {
            
            other.gameObject.SetActive(false);

            
            Invoke("EnablePlayer", disableTime);
        }
    }

    private void EnablePlayer()
    {
        
        gameObject.SetActive(true);

        
        triggerCount = 0;
    }
}

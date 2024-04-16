using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light2beta : MonoBehaviour
{
    public Light light;
    public Light light2;
    public Light light3;
    public float delay = 1f; 
    private int triggerCount = 0; 

    private void OnTriggerEnter(Collider other)
    {
        
        triggerCount++;

        
        if (other.gameObject.tag == "Player" && triggerCount == 2)
        {
            
            light.enabled = true;
            light2.enabled = true;
            light3.enabled = false;
            Invoke("DisableLight", delay);
        }
    }

    private void DisableLight()
    {
        
        light.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
        triggerCount = 0;
    }
}

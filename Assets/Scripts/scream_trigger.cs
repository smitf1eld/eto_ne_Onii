using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_screamer : MonoBehaviour
{
    public GameObject screamer;
    
    private void OnTrigger(Collider other)
    {
        if (this.CompareTag("screamer_trigger") && other.CompareTag("Player"))
        {
            screamer.SetActive(true);
            
        }
    }
}

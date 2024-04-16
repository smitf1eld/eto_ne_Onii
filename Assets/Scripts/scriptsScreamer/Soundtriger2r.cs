using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtriger2 : MonoBehaviour
{
    public AudioSource audioSource; 
    public float delay = 2f; 

    private bool hasEnteredTwice = false; 
    private float timeEntered; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            
            if (hasEnteredTwice)
            {
                
                Invoke("PlayAudioSource", delay);
            }
            else
            {
                
                timeEntered = Time.time;
                hasEnteredTwice = true;
            }
        }
    }

    private void PlayAudioSource()
    {
        audioSource.enabled = true;
    }
}

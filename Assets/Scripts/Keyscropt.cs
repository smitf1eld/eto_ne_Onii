using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyscropt : MonoBehaviour
{
    public GameObject key;
    public Canvas text;
    private bool inradius;
    
    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
        text.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
        inradius = false;
        
    }
    
    private void Update()
    {
        if (inradius)
        {
            text.gameObject.SetActive(true);
            
        
            if (Input.GetKeyDown(KeyCode.E))
            { 
                key.gameObject.SetActive(false);
                text.gameObject.SetActive(false);
                
            }

          
        }
    }
}

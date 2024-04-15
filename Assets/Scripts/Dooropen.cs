using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{
    public GameObject door;
    private bool inradius;
    void Start()
    {
        transform.Rotate(-90f, 0f, 90f);
       
    }

    
    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        
        inradius = false;
    }

    private void Update()
    {
        if (inradius)
        {
            if (Input.GetKeyDown(KeyCode.E))
            { 
                transform.Rotate(-90f, 90f, 90f);
                
            }
        }
    }
}

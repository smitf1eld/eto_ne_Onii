using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortest : MonoBehaviour
{
    public Canvas text;
    private bool inradius;
    public Animator mAnimator;
    
    private void OnTriggerEnter(Collider other)
    {
     text.gameObject.SetActive(true);
     inradius = true;

    }
    
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
        inradius = false;
    }

    private void Start()
    {
        text.gameObject.SetActive(false);
        

    }

    private void Update()
    {
        if (inradius)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                mAnimator.SetBool("Open", true);
            }
        }
    }
}

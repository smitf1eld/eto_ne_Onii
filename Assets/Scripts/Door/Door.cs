using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Door : MonoBehaviour, IInteractiable
{
    public Animator mAnimator;
    public bool isOpen;
    //public GameObject doorIsCloseText;

    private void Start()
    {
        if (isOpen)
        {
            mAnimator.SetBool("IsOpen", false );
        }
    }

    public string GetDescription()
    {
        if (isOpen)
        {
            return "[E]";
        }
        else
        {
            return " [E] ";
        }
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            //doorIsCloseText.SetActive(false);
            mAnimator.SetBool("IsOpen", true);
        }
       
    }
}

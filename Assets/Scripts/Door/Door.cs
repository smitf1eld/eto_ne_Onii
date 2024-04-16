using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractiable
{
    public Animator m_Animator;
    public bool isOpen;

    private void Start()
    {
        if (isOpen)
        {
            m_Animator.SetBool("isOpen", true );
        }
    }

    public string GetDescription()
    {
        if (isOpen)
        {
            return "Press [E] to close the door";
        }
        else
        {
            return "Press [E] to open the door";
        }
    }

    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            m_Animator.SetBool("IsOpen", true);
        }
        else
        {
            m_Animator.SetBool("IsOpen", false);
        }
    }
}

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
            m_Animator.SetBool("IsOpen", true);
        }
        else
        {
            m_Animator.SetBool("IsOpen", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorIvent : MonoBehaviour
{
    [SerializeField] public Animator DoorAnimator;
    [SerializeField] public bool Closed;

    public void TryOpen()
    {
        if (!Closed)
        {
            if (DoorAnimator.GetBool("interact") == false)
            {
                DoorAnimator.SetBool("interact", true);
            }
            else
            {
                DoorAnimator.SetBool("interact", false);
            }
        }
    }

    public void Unlock()
    {
        Closed = false;
    }
}

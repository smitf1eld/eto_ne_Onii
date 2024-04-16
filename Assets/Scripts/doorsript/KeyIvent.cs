using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIvent : MonoBehaviour
{
    [SerializeField] public DoorIvent Door;

    public void UnlockDoor()
    {
        Door.Unlock();
        
    }

}

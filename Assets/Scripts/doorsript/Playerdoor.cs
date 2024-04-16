using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playerdoor : MonoBehaviour
{
    [SerializeField] public KeyCode PickUp;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3))
        {
            if (hit.collider.tag == "key")
            {
                if (Input.GetKeyDown(PickUp))
                {
                    hit.collider.GetComponent<KeyIvent>().UnlockDoor();
                }
                
            }
            
            if (hit.collider.tag == "Door")
            {
                if (Input.GetKeyDown(PickUp))
                {
                    hit.collider.GetComponent<DoorIvent>().TryOpen();
                }
                
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerboxcollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 newPosition = transform.position;
            newPosition.y += 8f;
            transform.position = newPosition;
        }
    }

}

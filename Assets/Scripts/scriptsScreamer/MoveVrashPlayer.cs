using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVrashPlayer : MonoBehaviour
{
    public float rotationSpeed = 2000f; 

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            other.transform.Rotate(1000f, rotationSpeed * Time.deltaTime, 0f);
        }
    }
}

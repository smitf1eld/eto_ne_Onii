using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuvirla : MonoBehaviour
{
    private bool hasEntered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!hasEntered)
            {

                hasEntered = true;

            }
            else
            {
                StartCoroutine(LiftCoroutine());
                IEnumerator LiftCoroutine()
                {
                    transform.Translate(Vector3.up * 5);
                    yield return new WaitForSeconds(3);
                    transform.Translate(Vector3.up * 20);
                }

            }
        }
    }
} 



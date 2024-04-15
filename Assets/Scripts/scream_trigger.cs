using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_screamer : MonoBehaviour
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
                    for (int i = 2; i < 6; i++)
                    {
                        transform.Translate(Vector3.forward * i);
                        yield return new WaitForSeconds(1);
                    }
                    yield return new WaitForSeconds(1);
                    transform.Translate(Vector3.down * 5);
                }

            }
        }
    }
}
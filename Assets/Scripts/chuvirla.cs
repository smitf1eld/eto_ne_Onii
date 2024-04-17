using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuvirla : MonoBehaviour
{
    private bool _hasEntered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!_hasEntered)
            {

                _hasEntered = true;

            }
            else
            {
                StartCoroutine(LiftCoroutine());
                IEnumerator LiftCoroutine()
                {
                    transform.Translate(Vector3.up * 5);
                    yield return new WaitForSeconds(2);
                    transform.Translate(Vector3.up * 20);
                }

            }
        }
    }
} 



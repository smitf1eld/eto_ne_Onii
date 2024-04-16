using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VladScreamer : MonoBehaviour
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
                    
                    yield return new WaitForSeconds(1);
                    transform.Translate(Vector3.up * 5);
                    for (int i = 1; i < 5; i++)
                    {
                        transform.Translate(Vector3.down * 5);

                        int speed = 2;
                        transform.Translate(Vector3.back * speed);
                        yield return new WaitForSeconds((float)0.3);
                        transform.Translate(Vector3.up * 5);
                        yield return new WaitForSeconds((float)0.5);
                    }
                    yield return new WaitForSeconds((float)0.4);
                    transform.Translate(Vector3.down * 5);
                }
            }
        }
    }
}

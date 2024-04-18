using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
public class DoorCloseText2 : MonoBehaviour
{
    public GameObject key;
    public GameObject doorCloseText;
    public Canvas eshka;
    private bool _isInvisible = true;
    private bool _doorCloseTextActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_doorCloseTextActivated)
        {
            doorCloseText.SetActive(true);
            if (_isInvisible == false)
            {
                eshka.gameObject.SetActive(true);
            }
            _doorCloseTextActivated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorCloseText.SetActive(false);
            eshka.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (!key.activeInHierarchy)
        {
            doorCloseText.SetActive(false);
            _isInvisible = false;
        }
    }
}

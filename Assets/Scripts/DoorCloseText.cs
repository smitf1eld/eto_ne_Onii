using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorCloseText : MonoBehaviour
{
    public GameObject key;
    public GameObject doorCloseText;
    public Canvas eshka;
    private bool _isInvisible = true;

    private void OnTriggerEnter(Collider other)
    {
        doorCloseText.SetActive(true);
        if (_isInvisible == false)
        {
            eshka.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        doorCloseText.SetActive(false);
        eshka.gameObject.SetActive(false);
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

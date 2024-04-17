using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartText : MonoBehaviour
{
    public GameObject startText;
    

    private void OnTriggerEnter(Collider other)
    {
        startText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        startText.SetActive(false);
    }
}

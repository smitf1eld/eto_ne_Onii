using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLight : MonoBehaviour
{
    public GameObject redLight;

    private void Start()
    {
        redLight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        redLight.SetActive(true);
    }
}

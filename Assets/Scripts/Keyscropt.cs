using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Keyscropt : MonoBehaviour
{
    public GameObject key;
    public Canvas text;
    private bool _inRadius;
    public GameObject realDoor;
    public GameObject fakeDoor;
    private bool _keyVisible;
    private void Start()
    {
        realDoor.SetActive(false);
        fakeDoor.SetActive(true);
        _keyVisible = true;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _inRadius = true;
        text.gameObject.SetActive(true);
        
    }
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
        _inRadius = false;
        
    }
    
    private void Update()
    {
        if (_inRadius)
        {
            text.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            { 
                key.gameObject.SetActive(false);
                text.gameObject.SetActive(false);
                _keyVisible = false;
            }
        }
        if (_keyVisible == false)
        {
            realDoor.SetActive(true);
            fakeDoor.SetActive(false);
        }
        
        
    }
}

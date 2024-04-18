using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Keyscropt : MonoBehaviour
{
    public GameObject key;
    public Canvas text;
    private bool inradius;
    [FormerlySerializedAs("realydoor")] public GameObject realydoor1;
    [FormerlySerializedAs("fakedoor")] public GameObject fakedoor1;
    private bool keyvisiable;

    private void Start()
    {
        realydoor1.SetActive(false);
        fakedoor1.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
        text.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        text.gameObject.SetActive(false);
        inradius = false;
        
    }
    
    private void Update()
    {
        if (keyvisiable == false)
        {
            realydoor1.SetActive(true);
            fakedoor1.SetActive(false);
        }
        
        if (inradius)
        {
            text.gameObject.SetActive(true);
            
        
            if (Input.GetKeyDown(KeyCode.E))
            { 
                key.gameObject.SetActive(false);
                text.gameObject.SetActive(false);
                keyvisiable = false;
            }

          
        }
    }
}

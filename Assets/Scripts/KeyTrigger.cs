using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    
    public GameObject realydoor;
    public GameObject Fakedoor;
    public GameObject key;
    
    void Start()
    {
        realydoor.gameObject.SetActive(false);
        Fakedoor.gameObject.SetActive(true);
    }

    private void Update()
    {
        
    }
}

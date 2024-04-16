using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject doorrealy;
    public GameObject doorfake;
    
    void Start()
    {
        key.SetActive(true);
        doorfake.SetActive(true);
        doorrealy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (key == false)
        {
            doorfake.SetActive(false);
            doorrealy.SetActive(true);
        }
    }
}

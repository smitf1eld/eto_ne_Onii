using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;

public class MyMetod : MonoBehaviour
{
    public GameObject key;
    private bool inradius;
    public Canvas notice;
    
    void Start()
    {
        key.gameObject.SetActive(true);
        notice.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        notice.gameObject.SetActive(false);
        inradius = false;
    }
    
    void Update()
    {
        if (inradius)
        {
            notice.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                key.gameObject.SetActive(false);
            }
        }
    }
}

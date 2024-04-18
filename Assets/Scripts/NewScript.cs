using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    public GameObject key;
    public GameObject trigger;
    public Canvas text;
    
    
    void Start()
    {
        key.SetActive(true);
        text.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
    }
    
    void Update()
    {
            
                                                                                            
    }
}

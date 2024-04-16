using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    
    public GameObject realydoor;
    public GameObject Fakedoor;
    
    void Start()
    {
        realydoor.gameObject.SetActive(false);
        Fakedoor.gameObject.SetActive(true);
    }
    
    private void OnTriggerExit(Collider other)
    {
        realydoor.gameObject.SetActive(true);
        Fakedoor.gameObject.SetActive(false);
    }
 
  
}

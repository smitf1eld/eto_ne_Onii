using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropening : MonoBehaviour
{
    public Animator Animator;
    public GameObject door;
    public GameObject key;
    private int clikcount;
    public Canvas notice;
    private bool inradius;
    public Canvas notice1;
    void Start()
    {
        Animator = GetComponent<Animator>();
        notice.gameObject.SetActive(false);
        notice1.gameObject.SetActive(false);
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
            
            if (key == true)
            {
                notice1.gameObject.SetActive(true);
            }
            if (key == false)
            {
                notice.gameObject.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Animator.SetBool("isopen", true);
                    clikcount++;
                }
               
            }
            if (clikcount >= 1) 
            {
                notice.gameObject.SetActive(false);
            }
        }
        
    }
}

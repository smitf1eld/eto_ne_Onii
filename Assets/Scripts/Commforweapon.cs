using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Commforweapon : MonoBehaviour
{
    public Canvas notice;
    public int clikcount; 
    public Canvas Canvas;
    private bool inradius;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
        notice.gameObject.SetActive(false);
        clikcount = 0; 
    }

    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        notice.gameObject.SetActive(false);
        inradius = false;
        Canvas.gameObject.SetActive(false);
    }

    

    private void Update()
    {
        if (inradius)
        {
            notice.gameObject.SetActive(true);
            
        
            if (Input.GetKeyDown(KeyCode.E))
            { 
                Canvas.gameObject.SetActive(true);
                clikcount++; 
                if (clikcount == 2) 
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    SceneManager.LoadScene(2);
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Canvas.gameObject.SetActive(false);
            }
        }
    }
}
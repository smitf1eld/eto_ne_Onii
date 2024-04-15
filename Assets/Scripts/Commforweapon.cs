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
    public int scenenumbers;
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
                    SceneManager.LoadScene(scenenumbers);
                }
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Canvas.gameObject.SetActive(false);
            }
        }
    }
}
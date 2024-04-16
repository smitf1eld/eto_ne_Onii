using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    private bool _inRadius;
    public int scenenumbers;
    private void Start()
    {
        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        _inRadius = true;
    } 
    private void OnTriggerExit(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(scenenumbers);
    }
    

    private void Update()
    {
        if (_inRadius)
        {
            model1.gameObject.SetActive(true);
            model2.gameObject.SetActive(true);
        }
    }
}

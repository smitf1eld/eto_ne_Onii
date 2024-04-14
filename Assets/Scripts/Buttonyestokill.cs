using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttonyestokill : MonoBehaviour
{
    
    public int scenenumber;
    public void transition()
    {
        SceneManager.LoadScene(scenenumber);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    
}

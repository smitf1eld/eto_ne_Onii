using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonNo : MonoBehaviour
{
   
    public int scenenumber;
    public Vector3 targetPosition;
    public void transition()
    {
        SceneManager.LoadScene(scenenumber);
    }

    public void Teleport()
    {
        transform.position = targetPosition;
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    
}

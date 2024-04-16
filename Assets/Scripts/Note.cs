using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Note : MonoBehaviour
{
    public string noteTextstr;
    public GameObject notice;
    public GameObject noteUI;
    public TMP_Text text;
    private void OnTriggerStay(Collider other)
    {
        text.text = noteTextstr;
        notice.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            noteUI.SetActive(true);
            
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            noteUI.SetActive(false);
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        notice.SetActive(false);
        noteUI.SetActive(false);
    }
}

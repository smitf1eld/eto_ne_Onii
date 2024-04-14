using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   
    public int scenenumbers;
   

    void Update()
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(scenenumbers);
            }
        }
    }
}
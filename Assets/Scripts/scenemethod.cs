using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemethod2 : MonoBehaviour
{
    public int scennumbers;
    
    public void scenemethod()
    {
        SceneManager.LoadScene(scennumbers);
    }
}

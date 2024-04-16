using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



    
public class GoToMenu : MonoBehaviour

{
    public void SceneSwitch()
    {
        SceneManager.LoadScene(0);
    }
}

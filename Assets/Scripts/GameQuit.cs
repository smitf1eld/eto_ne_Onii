using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameQuit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Игра закылась");
        Application.Quit();
    }
}

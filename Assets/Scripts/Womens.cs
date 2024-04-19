using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


public class Womens : MonoBehaviour
{
    
    public Animator Animgirls;
    public Animator camanim;
    private bool inradius;
    public GameObject box;
    public int scenenumbers;
    public GameObject girls;

    private void Start()
    {
        girls.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        girls.SetActive(true);
        inradius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inradius = false;
    }

    void Update()
    {
        if (inradius)
        {
            StartCoroutine(StartAnimationAfterDelay());
            box.SetActive(true);
        }
    }

    IEnumerator StartAnimationAfterDelay()
    {
        // Ждем 5 секунд
        yield return new WaitForSeconds(5f);
        
        // Теперь играем анимацию
        Animgirls.Play("Womens");
        
        camanim.Play("CamAnim");
        
        yield return new WaitWhile(() => !camanim.IsInTransition(0));
    }

   
    
}

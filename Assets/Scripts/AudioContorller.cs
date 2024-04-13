using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioContorller : MonoBehaviour
{

    public Slider slider;

    public AudioClip clip;
    public AudioSource audio;
    void Start()
    {
        audio.volume = 100;
    }

    void Update()
    {
        audio.volume = slider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class Volume : MonoBehaviour
{

    

    
    public Slider slider;
    public AudioSource Audios;

    private void Start()
    {
        slider = GameObject.FindGameObjectWithTag("SliderV").GetComponent<Slider>();
        Audios = GetComponent<AudioSource>();
    }
    void Update()
    {
       
    }
    public void ValumeSl()
    {
        Audios.volume = slider.value;
    }

}

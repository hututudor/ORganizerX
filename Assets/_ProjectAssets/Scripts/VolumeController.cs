using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;
    
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        audioSource.volume = volumeSlider.value;
    }
    
    public void ChangeVolume()
    {
        audioSource.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}

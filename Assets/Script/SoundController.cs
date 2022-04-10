using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Slider songVolumeSlider;
    public Slider sfxVolumeSlider;

    public static float songVolume = 0.7f;
    public static float sfxVolume = 0.7f;
    public GameObject mainMenuAudio;

    private void Start()
    {
        songVolumeSlider.value = songVolume;
        sfxVolumeSlider.value = sfxVolume;
    }

    public void ChangeSongVolume()
    {
        songVolume = songVolumeSlider.value;
        mainMenuAudio.GetComponent<AudioSource>().volume = songVolume;
    }

    public void ChangeSFXVolume()
    {
        sfxVolume = sfxVolumeSlider.value;
    }
}

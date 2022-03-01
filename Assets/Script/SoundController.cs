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

    private void Start()
    {
        songVolumeSlider.value = songVolume;
        sfxVolumeSlider.value = sfxVolume;
    }

    public void ChangeSongVolume()
    {
        songVolume = songVolumeSlider.value;
    }

    public void ChangeSFXVolume()
    {
        sfxVolume = sfxVolumeSlider.value;
    }
}

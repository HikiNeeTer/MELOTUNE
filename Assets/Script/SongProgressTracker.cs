using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongProgressTracker : MonoBehaviour
{
    public Image progressBar;

    private float totalLength;

    void Start()
    {
        totalLength = GetComponent<AudioSource>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        progressBar.fillAmount = GetComponent<AudioSource>().time / totalLength;
    }
}

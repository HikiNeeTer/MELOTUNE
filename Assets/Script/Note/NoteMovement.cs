using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    public float beatTempo;
    public static bool hasStart;
    public Animator anim;

    void Start()
    {
        // Set Song Volume via SoungController.cs
        GetComponent<AudioSource>().volume = SoundController.songVolume;

        beatTempo /= 60.0f;
        hasStart = false;
    }

    void Update()
    {
        // If game start -> Note start move and song start play
        if (!hasStart)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("IsPlaying");
                hasStart = true;
                GetComponent<AudioSource>().Play();
            }
        }
        else
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}

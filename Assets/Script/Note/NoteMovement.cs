using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteMovement : MonoBehaviour
{
    public float beatTempo;
    public static bool hasStart;
    public GameObject SkillSelect;
    public Text StartText;

    void Start()
    {
        // Set Song Volume via SoungController.cs
        GetComponent<AudioSource>().volume = SoundController.songVolume;
        Time.timeScale = 0f;
        beatTempo /= 60.0f;
        hasStart = false;
    }

    void Update()
    {
        // If game start -> Note start move and song start play
        if (!hasStart && SkillSelect.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1f;
                hasStart = true;
                GetComponent<AudioSource>().Play();
                StartText.text = "";

            }
        }
        else
        {
            if (Time.timeScale > 0.0f)
            {
                transform.position -= new Vector3(beatTempo * Time.deltaTime, 0.0f, 0.0f);
            }
        }
    }
}

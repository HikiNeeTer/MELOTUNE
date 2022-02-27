using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameScene : MonoBehaviour
{
    public AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(song.isPlaying == false && NoteMovement.hasStart) 
        {
            Debug.Log("Scene warp");
            SceneManager.LoadScene("Tun_scene_result");
        }
    }
}

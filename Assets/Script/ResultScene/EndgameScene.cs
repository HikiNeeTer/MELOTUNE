using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameScene : MonoBehaviour
{
    public AudioSource song;

    void Update()
    {

        if(song.isPlaying == false && NoteMovement.hasStart && PauseGame.GameIsPaused == false) 
        {
            GoToResultScene();
        }
    }

    void GoToResultScene() 
    {
        StartCoroutine(GameEnd());
    }

    private IEnumerator GameEnd() 
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Tun_scene_result");
    }

}

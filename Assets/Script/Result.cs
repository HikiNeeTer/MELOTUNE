using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        score.text ="Total Score: " + ButtonCheck.Score;
    }

    public void Goback()
    {
        SceneManager.LoadScene("Tun_scene");
    }
}

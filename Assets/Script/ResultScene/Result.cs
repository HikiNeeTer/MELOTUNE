using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public Text score;
    public Text HighestCombo;
    public Text Perfect;
    public Text Great;
    public Text Good;
    public Text Miss;

    private void Start()
    {
        score.text ="Total Score: " + ButtonCheck.Score;
        HighestCombo.text = "Highest Combo: " + PlayerPrefs.GetInt("highcombo");
        Perfect.text = "Perfect: " + ButtonCheck.PerfectS;
        Great.text = "Great: " + ButtonCheck.GreatS;
        Good.text = "Good: " + ButtonCheck.GoodS;
        Miss.text = "Miss: " + ButtonCheck.MissS;
    }

    public void Goback()
    {
        SceneManager.LoadScene("Tun_scene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TestSceneChange : MonoBehaviour
{

    public void LoadScene(int TTscore) 
    {
        ScoreKeeper.TotalScore = TTscore;
        TTscore = ButtonCheck.Score;
        SceneManager.LoadScene("Tun_Scene_result");
    }
}

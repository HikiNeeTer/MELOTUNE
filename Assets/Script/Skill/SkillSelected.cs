using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelected : MonoBehaviour
{
    public GameObject character;
    public Text Describtion;
    void Start()
    {
        character.GetComponent<SkillEasy>().enabled = false;
        character.GetComponent<SecondSkill>().enabled = false;
    }



    // Update is called once per frame
    public void FirstActive()
    {
        character.GetComponent<SkillEasy>().enabled = true;
    }
    public void FirstHighlight() 
    {
        Describtion.text = "Convert miss to perfect for 1 time while skill is active";
    }

    public void SecondActive()
    {
        character.GetComponent<SecondSkill>().enabled = true;
    }

    public void SecondHighlight()
    {
        Describtion.text = "During the skill active. Perfect will gain extra 1000 point but miss will minus 1000 point";
    }

}

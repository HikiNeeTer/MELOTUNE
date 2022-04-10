using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelected : MonoBehaviour
{
    public GameObject character;
    public GameObject SkillB;
    public Text SkillT;
    public Text Describtion;

    void Start()
    {
        character.GetComponent<SkillEasy>().enabled = false;
        character.GetComponent<SecondSkill>().enabled = false;
        character.GetComponent<ThirdSkill>().enabled = false;
    }
    // Update is called once per frame
    public void FirstActive()
    {
        character.GetComponent<SkillEasy>().enabled = true;
    }
    public void FirstHighlight() 
    {
        Describtion.text = "Convert miss to perfect for 1 time while skill is active";
        Describtion.color = new Color(0.2784314f, 0.8941177f, 0.8823529f, 1.0f);
    }

    public void SecondActive()
    {
        character.GetComponent<SecondSkill>().enabled = true;
    }

    public void SecondHighlight()
    {
        Describtion.text = "During the skill active. Perfect will gain extra 1000 point but miss will minus 1000 point";
        Describtion.color = Color.magenta;
    }

    public void ThirdActive()
    {
        character.GetComponent<ThirdSkill>().enabled = true;
        SkillB.SetActive(false);
        SkillT.text = "";
    }
    public void ThirdHighlight()
    {
        Describtion.text = "(Passive) If your combo is higher than 50. Every note hit will gain extra point";
        Describtion.color = Color.green;
    }
}

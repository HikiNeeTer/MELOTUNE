using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSelected : MonoBehaviour
{
    public GameObject character;
    void Start()
    {
        character.GetComponent<SkillEasy>().enabled = false;
        character.GetComponent<SecondSkill>().enabled = false;
    }

    private void Update()
    {
        if (gameObject.activeSelf) 
        {

        }
    }

    // Update is called once per frame
    public void FirstActive()
    {
        character.GetComponent<SkillEasy>().enabled = true;
    }

    public void SecondActive()
    {
        character.GetComponent<SecondSkill>().enabled = true;
    }
}

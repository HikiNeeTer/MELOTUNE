using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSkill : MonoBehaviour
{
    public ButtonCheck BC;
    public MissBarrier NO;
    public Text Display;
    public static bool isskill;
    private float skillduration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Display.text = "Skill Duration:" + skillduration.ToString("F2");
        if(skillduration < 0) 
        {
            skillduration = 0;
        }
        ActiveSkill();
    }

    void ActiveSkill() 
    {
        if (SkillBar.AmountSkill >= 100f)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                skillduration = 5.0f;
                isskill = true;
                SkillBar.AmountSkill = 0f;
            }           
        }
        if (isskill == true)
        {
            skillduration -= Time.deltaTime;
            SkillBar.AmountSkill = 0f;
            if (skillduration <= 0)
            {
                isskill = false;
            }

            if (NO.NoteMiss || BC.NoteWrong)
            {
                ButtonCheck.Score -= 1000;
                NO.NoteMiss = false;
                BC.NoteWrong = false;
            }
            if (BC.NotePerfect) 
            {
                ButtonCheck.Score += 1000;
                BC.NotePerfect = false;
            }
        }
    }
}

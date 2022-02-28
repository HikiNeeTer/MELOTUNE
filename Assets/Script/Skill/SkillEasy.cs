using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillEasy : MonoBehaviour
{
    public ButtonCheck BC;
    public MissBarrier NO;
    public Text Display;
    public Text Gtext;
    public bool isskill;
    public int skillamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Display.text = "Skill left : " + skillamount;
        SkillActive();
    }

    public void SkillActive() 
    {
        if (SkillBar.AmountSkill >= 100f)
        {
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                skillamount = 5;
                isskill = true;
                SkillBar.AmountSkill = 0f;                                             
            }
        }
        if(isskill == true) 
        {
            SkillBar.AmountSkill = 0f;
            if (skillamount == 0)
            {
                isskill = false;
            }
            if (NO.NoteMiss && skillamount > 0)
            {
                ButtonCheck.Combo += 1;
                ButtonCheck.Score += 1000;               
                skillamount--;
                Gtext.text = "Perfect by skill";
                NO.NoteMiss = false;
                BC.NoteWrong = false;
            }
            
        }
    }
}

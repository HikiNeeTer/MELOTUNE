using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillEasy : MonoBehaviour
{
    public ButtonCheck BC;
    public MissBarrier NO;
    public GameObject skillBar;
    public Text Display;
    public Text Gtext;
    public bool isskill;
    public int skillamount;
    public Color skillColor;
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

    void SkillActive() 
    {
        if (SkillBar.AmountSkill >= 100f)
        {
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                skillamount = 1;
                ButtonCheck.isSkillUsed = true;
                isskill = true;
                SkillBar.AmountSkill = 0f;
                skillBar.GetComponent<Image>().color = skillColor;
            }
        }
        if(isskill == true) 
        {
            SkillBar.AmountSkill = 99.9f;
            if (skillamount == 0)
            {
                skillBar.GetComponent<Image>().color = Color.white;
                SkillBar.AmountSkill = 0.0f;
                ButtonCheck.isSkillUsed = false;
                isskill = false;
            }
            if (NO.NoteMiss && skillamount > 0)
            {
                ButtonCheck.Combo += 1;
                ButtonCheck.Score += 1000;               
                skillamount--;
                NO.NoteMiss = false;
                BC.NoteWrong = false;
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillEasy : MonoBehaviour
{
    public ButtonCheck BC;
    public MissBarrier NO;
    public bool isskill;
    public int skillamount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
                Debug.Log("Skill is activate");
                SkillBar.AmountSkill = 0f;                                             
            }
        }
        if(isskill == true) 
        {
            if (skillamount == 0)
            {
                isskill = false;
            }
            if (NO.NoteMiss && skillamount > 0)
            {
                Debug.Log("Miss is perfect");
                ButtonCheck.Combo += 1;
                ButtonCheck.Score += 1000;               
                skillamount--;
                Debug.Log("SkillAmount = " + skillamount);
                NO.NoteMiss = false;
                BC.NoteWrong = false;
            }
            
        }
    }
}

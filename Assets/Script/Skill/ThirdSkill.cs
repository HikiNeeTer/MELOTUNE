using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdSkill : MonoBehaviour
{
    public ButtonCheck BC;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


       if(ButtonCheck.Combo > 50) 
       {
            if (BC.NotePerfect)
            {
                ButtonCheck.Score += 500;
                BC.NotePerfect = false;
            }
            else if (BC.NoteGreat) 
            {
                ButtonCheck.Score += 250;
                BC.NoteGreat = false;
            }
            else if (BC.NoteGood) 
            {
                ButtonCheck.Score += 150;
                BC.NoteGood = false;
            }
       }
    }

   
       
}

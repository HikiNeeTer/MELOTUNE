using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyCalculation : MonoBehaviour
{
    private int allNote;
    private float accuracy;
    public Text AccuracyText;
    public Text GradeText;
    void Start()
    {
        allNote = ButtonCheck.PerfectS + ButtonCheck.GreatS + ButtonCheck.GoodS + ButtonCheck.MissS;
    }

    // Update is called once per frame
    void Update()
    {
        accuracy = ((ButtonCheck.PerfectS + (ButtonCheck.GreatS / 2.0f) - ButtonCheck.GoodS - ButtonCheck.MissS) / (float)allNote) * 100.0f;

        AccuracyText.text = "Accuracy: " + accuracy.ToString("F2") + "%";
        Grade();
    }

    void Grade()    
    {
        if (accuracy > 95.0f) 
        {
            GradeText.text = "Grade : S"; 
        }
        else if (accuracy > 90.0f)
        {
            GradeText.text = "Grade : A";
        }
        else if (accuracy > 80.0f)
        {
            GradeText.text = "Grade : B";
        }
        else if (accuracy > 70.0f)
        {
            GradeText.text = "Grade : C";
        }
        else if (accuracy > 60.0f)
        {
            GradeText.text = "Grade : D";
        }
        else if (accuracy < 60.0f)
        {
            GradeText.text = "Grade : F";
        }
    }
}
